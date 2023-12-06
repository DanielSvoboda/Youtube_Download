using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Youtube_Download
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string versao = "4";

        string tempFolderPath = Path.Combine(Path.GetTempPath(), "YoutubeDownloadTempFolder");

        string title;
        string author;
        int viewCount;
        string thumbnail;
        string shortDescription;

        string mp3;
        string video;

        byte[] outputBytesFFMPEG = null;      // "ffmpeg_empacotado_pra_viagem" descompactado


        private void linkLabel_colar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false;
            textBox_url.Text = Clipboard.GetText();
            coletarDados();
            this.Enabled = true;
        }

        private void button_baixarAudio_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            BaixarArquivoAsync(mp3, "Audio");
        }

        private void button_baixarVideo_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            BaixarArquivoAsync(video, "Video");
        }

        private void buttonbaixarVIdeoComAudio_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            baixarVideoComAudio();
        }

        private async void coletarDados()
        {
            if (!Uri.TryCreate(textBox_url.Text, UriKind.Absolute, out var uri))
            {
                MessageBox.Show(textBox_url.Text+"\nNão é um link válido, insira um link do youtube");
                textBox_url.Text = "";
                return;
            }

            title = "";
            author = "";
            viewCount = 0;
            thumbnail = "";
            shortDescription = "";
            mp3 = "";
            video = "";
            progressBar1.Value = 0;

            // Baixar o conteúdo do script do YouTube
            WebClient webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            string scriptUrl = "https://www.youtube.com/iframe_api";
            string scriptContent = webClient.DownloadString(scriptUrl);
            string signatureTimestamp = "";

            // Extrair a sequência da versão do script
            var nun_inicio2 = scriptContent.IndexOf("player");
            var nun_final = scriptContent.IndexOf("www-widgetapi", nun_inicio2 + 1); // Procura a próxima ocorrência de "www-widgetapi" após o início

            // Corta o conteúdo entre as duas ocorrências
            var sequenciaVersao = scriptContent.Substring(nun_inicio2 + 8, nun_final - (nun_inicio2 + 10));

            Console.WriteLine($"Valor de sequenciaVersao: {sequenciaVersao}");

            // Construir a nova URL e baixar o conteúdo
            string novaUrl = $"https://www.youtube.com/s/player/{sequenciaVersao}/player_ias.vflset/pt_BR/base.js";
            string novoConteudo = webClient.DownloadString(novaUrl);

            // Procurar "signatureTimestamp" e obter o valor
            Match match = Regex.Match(novoConteudo, @"signatureTimestamp:(\d+)");
            if (match.Success)
            {
                signatureTimestamp = match.Groups[1].Value;
                Console.WriteLine($"Valor de signatureTimestamp: {signatureTimestamp}");
            }
            else
            {
                Console.WriteLine("Não foi possível encontrar signatureTimestamp.");
            }

            //Corta o conteudo e pega o INNERTUBE_API_KEY
            var html_original = new WebClient().DownloadString(textBox_url.Text);
            var nun_inicio = html_original.IndexOf("INNERTUBE_API_KEY");
            var INNERTUBE_API_KEY = html_original.Substring(nun_inicio + 20, 39);
            Console.WriteLine($"INNERTUBE_API_KEY: {INNERTUBE_API_KEY}");

            //Corta o conteudo e pega o INNERTUBE_CLIENT_VERSION
            nun_inicio = html_original.IndexOf("INNERTUBE_CLIENT_VERSION");
            var INNERTUBE_CLIENT_VERSION = html_original.Substring(nun_inicio + 27, 16);
            Console.WriteLine($"INNERTUBE_CLIENT_VERSION: {INNERTUBE_CLIENT_VERSION}");

            //Corta o conteudo e pega o videoId
            nun_inicio = html_original.IndexOf("videoDetails\":{\"videoId");
            var videoId = html_original.Substring(nun_inicio + 26, 11);
            Console.WriteLine($"videoId: {videoId}");

            var url = "https://youtubei.googleapis.com/youtubei/v1/player?key=" + INNERTUBE_API_KEY;
            var client = new HttpClient();

            var postData = new
            {
                videoId = videoId,
                racyCheckOk = true,
                contentCheckOk = true,

                context = new
                {
                    client = new
                    {
                        hl = "en",
                        clientName = "WEB",
                        clientVersion = INNERTUBE_CLIENT_VERSION,
                        mainAppWebInfo = new
                        {
                            graftUrl = "/watch?v=" + videoId
                        }
                    },

                    thirdParty = new
                    {
                        embedUrl = "https://www.youtube.com"
                    },
                },

                playbackContext = new
                {
                    contentPlaybackContext = new
                    {
                        signatureTimestamp = signatureTimestamp
                    }
                }
            };

            var json2 = JsonConvert.SerializeObject(postData);
            var content = new StringContent(json2, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
            var responseContent = "";
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Solicitação POST bem-sucedida!");

                responseContent = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(responseContent);
            }
            else
            {
                Console.WriteLine($"Erro na solicitação POST: {response.StatusCode}");
            }

            var json = JObject.Parse(responseContent);

            title = json["videoDetails"]["title"].ToString();
            author = json["videoDetails"]["author"].ToString();
            viewCount = (int)json["videoDetails"]["viewCount"]; //nao funciona no shorts
            thumbnail = json["videoDetails"]["thumbnail"].ToString();
            //shortDescription = json["videoDetails"]["shortDescription"].ToString();

            JObject conteudo_pagina = JObject.Parse(thumbnail);
            var obj_video = from p in conteudo_pagina["thumbnails"]
                            select (string)p["url"];     // links dos videos

            string tempURLthumbnails = "";
            foreach (var item in obj_video)
            {
                Console.WriteLine(item);
                if (item != null)      // se o link nao for 'null'
                {
                    tempURLthumbnails = item;
                    //temp.Split(new[] { "hqdefault.jpg" }, StringSplitOptions.None);                    
                }
            }
            thumbnail = tempURLthumbnails;


            label_titulo.Text = title;
            label_autor_view.Text = author + "    " + viewCount.ToString("#,0") + " visualizações"; ;
            pictureBox1.ImageLocation = thumbnail;


            int maiorBitrateAudio = 0;
            int maiorBitrateVideo = 0;

            var streamingData = json["streamingData"].ToString();
            JObject conteudo_pagina2 = JObject.Parse(streamingData);
            var adaptiveFormats = conteudo_pagina2["adaptiveFormats"];
            foreach (var format in adaptiveFormats)
            {
                Console.WriteLine("itag: " + format["itag"]);
                Console.WriteLine("url: " + format["url"]);
                Console.WriteLine("mimeType: " + format["mimeType"]);
                Console.WriteLine("bitrate: " + format["bitrate"]);
                Console.WriteLine("width: " + format["width"]);
                Console.WriteLine("height: " + format["height"]);
                Console.WriteLine("lastModified: " + format["lastModified"]);
                Console.WriteLine("quality: " + format["quality"]);
                Console.WriteLine("fps: " + format["fps"]);
                Console.WriteLine("qualityLabel: " + format["qualityLabel"]);
                Console.WriteLine("projectionType: " + format["projectionType"]);
                Console.WriteLine("audioQuality: " + format["audioQuality"]);
                Console.WriteLine("approxDurationMs: " + format["approxDurationMs"]);
                Console.WriteLine("audioSampleRate: " + format["audioSampleRate"]);
                Console.WriteLine("audioChannels: " + format["audioChannels"]);
                Console.WriteLine("loudnessDb: " + format["loudnessDb"]);

                Console.WriteLine("signatureCipher: " + format["signatureCipher"]);

                Console.WriteLine();

                // URL do melhor audio (maior bitrate)
                if (format["audioQuality"] != null && format["audioQuality"].ToString() != "")
                {
                    int bitrate = int.Parse(format["bitrate"].ToString());
                    if (bitrate > maiorBitrateAudio)
                    {
                        maiorBitrateAudio = bitrate;
                        if (format["signatureCipher"] == null)
                        {
                            mp3 = format["url"].ToString();
                            Console.WriteLine("mp3Normal:" + mp3);
                        }
                        else
                        {
                            mp3 = decodeCipher.DecodeCipher(format["signatureCipher"].ToString());
                            Console.WriteLine("mp3Cipher:" + mp3);
                        }
                    }
                }

                // URL do melhor vídeo (maior bitrate)
                if (format["audioQuality"] == null)
                {
                    int bitrate = int.Parse(format["bitrate"].ToString());
                    if (bitrate > maiorBitrateVideo)
                    {
                        maiorBitrateVideo = bitrate;
                        if (format["signatureCipher"] == null)
                        {
                            video = format["url"].ToString();
                            Console.WriteLine("videoNormal:" + video);
                        }
                        else
                        {
                            video = decodeCipher.DecodeCipher(format["signatureCipher"].ToString());
                            Console.WriteLine("videoNormal:" + video);
                        }
                    }
                }
            }
        }



        private async Task BaixarArquivoAsync(string url, string fileType)
        {
            string urlDecodificada = HttpUtility.UrlDecode(url);
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (fileType == "Video")
            {
                saveFileDialog.Filter = "Arquivos de Vídeo (*.mp4)|*.mp4";
                saveFileDialog.Title = "Escolha o local para salvar o arquivo de Vídeo";
            }
            else if (fileType == "Audio")
            {
                saveFileDialog.Filter = "Arquivos de Áudio (*.mp3)|*.mp3";
                saveFileDialog.Title = "Escolha o local para salvar o arquivo de áudio";
            }

            saveFileDialog.FileName = LimparNomeArquivo(label_titulo.Text);

            // Mostrar o diálogo e verificar se o usuário clicou em "Salvar"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obter o caminho escolhido pelo usuário
                string outputPath = saveFileDialog.FileName;

                // Criar uma instância do Downloader
                var downloader = new Downloader(urlDecodificada, outputPath, tempFolderPath, progressBar1);

                try
                {
                    // Baixar o arquivo assincronamente
                    await downloader.DownloadFileAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao iniciar o download: {ex.Message}");
                }

                this.Enabled = true;
                MessageBox.Show("Download concluído!");
            }
        }



        private async void baixarVideoComAudio() // e unifica com ffmpeg
        {
            string tempVideoPath = "";
            string tempAudioPath = "";
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos de Vídeo (*.mp4)|*.mp4";
                saveFileDialog.Title = "Escolha o local para salvar o arquivo de Vídeo";
                saveFileDialog.FileName = LimparNomeArquivo(label_titulo.Text);

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string urlDecodificadaVideo = HttpUtility.UrlDecode(video);
                    string urlDecodificadaAudio = HttpUtility.UrlDecode(mp3);

                    // Baixe o vídeo de forma assíncrona
                    var videoDownloader = new Downloader(urlDecodificadaVideo, Path.Combine(tempFolderPath, "temp_video.mp4"), tempFolderPath, progressBar1);
                    await videoDownloader.DownloadFileAsync();

                    // Baixe o audio de forma assíncrona
                    var audioDownloader = new Downloader(urlDecodificadaAudio, Path.Combine(tempFolderPath, "temp_audio.mp3"), tempFolderPath, progressBar1);
                    await audioDownloader.DownloadFileAsync();

                    // Unifica o vídeo e áudio com ffmpeg
                    tempVideoPath = Path.Combine(tempFolderPath, "temp_video.mp4");
                    tempAudioPath = Path.Combine(tempFolderPath, "temp_audio.mp3");
                    string saidaFinalPath = Path.Combine(tempFolderPath, "saida_final.mp4");
                    await unificar_video_e_audio(tempVideoPath, tempAudioPath, saidaFinalPath);

                    // Mova o arquivo final para o local escolhido pelo usuário
                    File.Move(saidaFinalPath, saveFileDialog.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}");
            }
            finally
            {
                this.Enabled = true;
                MessageBox.Show("Download concluído!");


                // Deleta os arquivos temporarios
                File.Delete(tempVideoPath);
                File.Delete(tempAudioPath);
            }
        }



        public async Task unificar_video_e_audio(string entradaVideo, string entradaAudio, string saida)
        {
            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localFfmpeg = Path.Combine(localAppData, "ffmpeg.exe");

            if (File.Exists(localFfmpeg))
            {
                string comando = $"-i \"{entradaVideo}\" -i \"{entradaAudio}\" -c:v copy -c:a aac -strict experimental \"{saida}\"";

                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    FileName = localFfmpeg,
                    Arguments = comando,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true
                };

                using (Process exeProcess = Process.Start(startInfo))
                {
                    string error = await exeProcess.StandardError.ReadToEndAsync();
                    string output = await exeProcess.StandardOutput.ReadToEndAsync();

                    await Task.Run(() => exeProcess.WaitForExit()); // Aguardar a conclusão do processo em uma tarefa separada

                    // Verificar erros ou lidar com a saída, se necessário
                    if (!string.IsNullOrEmpty(error))
                    {
                        //MessageBox.Show("ERROR:" + error);
                    }
                }
            }
            else
            {
                desempacotador_GZipStream();
            }
        }



        public void desempacotador_GZipStream()     //função Decompress desempacotador_GZipStream
        {
            byte[] inputBytes = Properties.Resources.ffmpeg_empacotado_pra_viagem;

            using (var inputStream = new MemoryStream(inputBytes))
            using (var gZipStream = new GZipStream(inputStream, CompressionMode.Decompress))
            using (var outputStream = new MemoryStream())
            {
                gZipStream.CopyTo(outputStream);
                outputBytesFFMPEG = outputStream.ToArray();

                var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var localFfmpeg = Path.Combine(localAppData, "ffmpeg.exe");

                File.WriteAllBytes(localFfmpeg, outputBytesFFMPEG); // salva em localAppData
            }
        }



        private string LimparNomeArquivo(string nome)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            return new string(nome.Where(c => !invalidChars.Contains(c)).ToArray());
        }



        private void button_atualizar_Click(object sender, EventArgs e)
        {
            var url_versao = "https://raw.githubusercontent.com/DanielSvoboda/Youtube_Download/main/versao.txt";
            var url_exe = "https://raw.githubusercontent.com/DanielSvoboda/Youtube_Download/main/Youtube_Download_DSS.exe";

            WebRequest solicitacao = HttpWebRequest.Create(url_versao);
            WebResponse resposta = solicitacao.GetResponse();
            StreamReader sr = new StreamReader(resposta.GetResponseStream());
            string conteudo = sr.ReadToEnd();

            if (conteudo != versao)
            {
                DialogResult dialogResult = MessageBox.Show("Existe uma atualização! \n" +
                    "Vamos atualizar agora?", "Atualização Disponivel", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var dir = Directory.GetCurrentDirectory();
                    var nome_antigo = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + ".exe";
                    var nome_novo = Directory.GetCurrentDirectory() + @"\Youtube_Download_DSS" + conteudo + ".exe";

                    var wClient = new WebClient();
                    wClient.DownloadFile(url_exe, nome_novo);

                    MessageBox.Show("Download concluído!");

                    //inicia uma therd fecha o programa, espera 3 segundos, apaga o antigo, renomeia o novo com o mesmo nome do antigo e abre ele:)
                    Process.Start(new ProcessStartInfo()
                    {
                        Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + dir + "\\" + nome_antigo + "\"" + " & ren \"" + nome_novo + "\"" + " " + "\"" + nome_antigo + "\"" + " & start /d " + "\"" + dir + "\"" + " " + nome_antigo,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        CreateNoWindow = true,
                        FileName = "cmd.exe"
                    }); ;

                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Não existe atualização disponivel ;)");
            }
        }

        private void linkLabel_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda/Youtube_Download");
        }
    }
}