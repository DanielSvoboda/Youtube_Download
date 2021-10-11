using System;
using System.Windows.Forms;
using VideoLibrary;
using System.Net;
using System.IO;
using System.Drawing;
using System.Diagnostics;
using System.IO.Compression;
using Youtube_Download.Properties;


namespace Youtube_Download_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(383, 193);
            //localFfmpeg = Settings.Default["LocalFfmpeg"].ToString();
            //textBox_LocalFfmpeg.Text = Settings.Default["LocalFfmpeg"].ToString();    //textbox carrega do save

        }

        //string novo_local = Settings.Default["LocalFfmpeg"].ToString();

        bool formato = true; // True =MP3     False =MP4
        bool MODO_FFMPEG = false;
        string formato_extencao = "mp3 files (*.mp3)|*.mp3";
        string diretorio_conv_in = "";
        string diretorio_conv_out = "";
        string nome_do_titulo = "";

        string versao = "2"; 

        byte[] outputBytes = null;      // "ffmpeg_empacotado_pra_viagem" descompactado

        //MENU DOWNLOAD
        private void dOWNLOADToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            GRUPO_DOWNLOAD.Visible = true;
            GRUPO_CONVERTER.Visible = false;
            GRUPO_SOBRE.Visible = false;

            GRUPO_DOWNLOAD.Location = new Point(12, 27);
        }


        //MENU CONVERSOR
        private void cONVERTERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GRUPO_DOWNLOAD.Visible = false;
            GRUPO_CONVERTER.Visible = true;
            GRUPO_SOBRE.Visible = false;

            GRUPO_CONVERTER.Location = new Point(12, 27);
        }
        

        //MENU SOBRE
        private void sOBREToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GRUPO_DOWNLOAD.Visible = false;
            GRUPO_CONVERTER.Visible = false;
            GRUPO_SOBRE.Visible = true;

            GRUPO_SOBRE.Location = new Point(12, 27);
        }


        // Alterar entre os botões MP3 e MP4
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            formato = true;
            formato_extencao = "mp3 files (*.mp3)|*.mp3";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            formato = false;
            formato_extencao = "mp4 files (*.mp4)|*.mp4";
        }

        // Botão 'ABRIR O SITE YOUTUBE'
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com");
        }

        // Botão Colar
        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            textBox_link_do_youtube.Text = Clipboard.GetText();
        }

        // Botão abrir github
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/DanielSvoboda");
        }

        // Botão abrir Depencenia
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nuget.org/packages/VideoLibrary");
        }

        private void linkLabel1_LinkClicked_2(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.nuget.org/packages/Costura.Fody");
        }

        // Botão modo de converção- em desenvolvimento
        private void MODO_NORMAL_Click(object sender, EventArgs e)
        {
            MODO_FFMPEG = false;    // modo normal - false
            MODO_NORMAL.Enabled = false;
            MODO_AVANCADO.Enabled = true;
        }

        // Botão modo de converção- em desenvolvimento
        private void MODO_AVANCADO_Click(object sender, EventArgs e)
        {
            MODO_FFMPEG = true;     // modo avancado - true
            MODO_NORMAL.Enabled = true;
            MODO_AVANCADO.Enabled = false;
        }

        void Nome_Titulo()     // Função obter o titulo do vídeo
        {
            try
            {   WebRequest solicitacao = HttpWebRequest.Create(textBox_link_do_youtube.Text);
                WebResponse resposta;
                resposta = solicitacao.GetResponse();
                StreamReader sr = new StreamReader(resposta.GetResponseStream());
                string entrada = sr.ReadToEnd();
                int inicio = entrada.IndexOf("<title>") + 7; // apagar o começo  '<title>'
                int bitis = entrada.Substring(inicio).IndexOf("</title>") - 10; // apaga o final' - youtube'
                nome_do_titulo = entrada.Substring(inicio, bitis);
                label_nomeDoVideo.Text = nome_do_titulo;

                // remover caracteres invalidos na hora de salvar um arquivo no windows
                nome_do_titulo = nome_do_titulo.Replace("\\", " ");                     // remove:  \
                nome_do_titulo = nome_do_titulo.Replace("/", " ");                      // remove:  /
                nome_do_titulo = nome_do_titulo.Replace(":", " ");                      // remove:  :
                nome_do_titulo = nome_do_titulo.Replace("*", " ");                      // remove:  *
                nome_do_titulo = nome_do_titulo.Replace("?", " ");                      // remove:  ?
                nome_do_titulo = nome_do_titulo.Replace("\"", " ");                     // remove:  "
                nome_do_titulo = nome_do_titulo.Replace("<", " ");                      // remove:  <
                nome_do_titulo = nome_do_titulo.Replace(">", " ");                      // remove:  >
                nome_do_titulo = nome_do_titulo.Replace("|", " ");                      // remove:  |
            }
            catch
            {   MessageBox.Show("Ocorreu um erro ao entender o titulo do vídeo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);            }
        }


        //Botão Baixar
        public async void Botao_baixar_async(object sender, EventArgs e)
        {
            progressBar1.Value = 0;

            if (textBox_link_do_youtube.Text == "")
            {
                MessageBox.Show("Por favor, cole um link para poder baixar!");
                return;
            }

            Nome_Titulo();     // Chama a função de reconhecer o nome do vídeo 
         
            SaveFileDialog sfd = new SaveFileDialog();  // tela escolha de diretorio para salvar
            sfd.FileName = nome_do_titulo;              // nome do arquivo é igual ao nome do vídeo(corrigido)
            sfd.Filter = formato_extencao;              // exibe apenas .mp3 ou .mp4, conforme escolhido
            sfd.Title = "Escolha um local para salvar";
            sfd.ValidateNames = true;
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var yt = YouTube.Default;
                    var link_video = await yt.GetVideoAsync(textBox_link_do_youtube.Text);
                    string diretorio_nome_mp3 = sfd.FileName;                                                    //diretorio/nome.mp3
                    string diretorio_nome_mp4 = sfd.FileName.Remove(sfd.FileName.Length - 1) + "4";              //diretorio/nome.mp4
                    string diretorio_nome_mp4_temp = sfd.FileName.Remove(sfd.FileName.Length - 4) + "_temp.mp4"; //diretorio/nome_temp.mp4

                    
                    if (formato == true)    //se formato true=mp3   salva temp.MP4, converte e apagar temp.MP4
                    {
                        File.WriteAllBytes(diretorio_nome_mp4_temp, await link_video.GetBytesAsync());  //salva _temp.mp4
                        converter_video_para_mp3(diretorio_nome_mp4_temp, diretorio_nome_mp3);          //converte temp.mp4 para mp3
                        File.Delete(diretorio_nome_mp4_temp);                                           //Deleta _temp.mp4
                    }
                    else                    //se formato false(MP4)    Salva arquivo nome.mp4  
                    {
                        File.WriteAllBytes(diretorio_nome_mp4, await link_video.GetBytesAsync());
                    }

                    //float tamanho = (float)(new FileInfo(diretorio_nome_mp4).Length * 0.000001);   // tamanho em MB

                    progressBar1.Value = 100;
                    MessageBox.Show("Baixado com sucesso!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox_link_do_youtube.Text = "";
                }
                else
                { MessageBox.Show("Escolha um local valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }            
        }


        //ESCOLHER ARQUIVO PARA CONVERTER
        private void escolher_conv_input_Click(object sender, EventArgs e)
        {            
            OpenFileDialog ofd = new OpenFileDialog();  // tela escolha de diretorio abrir
            ofd.Title = "Escolha um arquivo de vídeo, para transformalo em audio (MP3)";
            ofd.Filter = "Arquivos de vídeo |*.mp4;*.mov;*.m4a;*.3gp;*.3g2;*.mj2";  
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                label_TITULO_CONV.Text = ofd.SafeFileName;
                diretorio_conv_in = ofd.FileName;
                diretorio_conv_out = ofd.FileName.Remove(ofd.FileName.Length - 3) + "mp3"; 
            }
        }


        // FUNÇÃO CONVERTE VIDEO EM AUDIO
        public void converter_video_para_mp3(string entrada, string saida)
        {
            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localFfmpeg = Path.Combine(localAppData, "ffmpeg.exe");
            
            if (File.Exists(localFfmpeg))    //o arquivo ffmpeg.exe já existe no local selecionado? 
            {
                string aspa = "\"";
                string comando = " -i " + aspa + entrada + aspa + " -f mp3 " + aspa + saida + aspa;

                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.CreateNoWindow = true;   // true = invisivel   false=mostra o console preto
                startInfo.UseShellExecute = false; // só funciona false
                startInfo.FileName = localFfmpeg;
                //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.Arguments = comando;

                startInfo.RedirectStandardOutput = true;
                startInfo.RedirectStandardError = true;

                using (Process exeProcess = Process.Start(startInfo))
                {
                    string error = exeProcess.StandardError.ReadToEnd();
                    string output = exeProcess.StandardError.ReadToEnd();
                    exeProcess.WaitForExit();                    
                    //MessageBox.Show("ERROR:" + error); 
                }                
            }
            else
            {
                desempacotador_GZipStream();
            }
        }


        private void Botao_converter(object sender, EventArgs e)
        {
            var entrada = diretorio_conv_in;
            var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            var localFfmpeg = Path.Combine(localAppData, "ffmpeg.exe");

            if (File.Exists(localFfmpeg))    //o arquivo ffmpeg.exe já existe no local? 
            {
                if (entrada != "")
                {
                    SaveFileDialog ofd2 = new SaveFileDialog();  // tela escolha de diretorio salvar
                    ofd2.Title = "Escolha um local para salvar o audio (MP3)";
                    ofd2.Filter = "mp3 files (*.mp3)|*.mp3";
                    ofd2.FileName = diretorio_conv_out;

                    if (ofd2.ShowDialog() == DialogResult.OK)
                    {
                        converter_video_para_mp3(entrada, ofd2.FileName);
                        MessageBox.Show("Arquivo convertido! \n" + label_TITULO_CONV.Text, "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label_TITULO_CONV.Text = "CONVERTER ARQUIVOS DE VÍDEO EM AUDIO (MP3)";
                    }
                }
                else
                {
                    MessageBox.Show("Escolha um local valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                desempacotador_GZipStream();
            }
        }


        public void desempacotador_GZipStream()     //função Decompress desempacotador_GZipStream
        {
            byte[] inputBytes = Youtube_Download.Properties.Resources.ffmpeg_empacotado_pra_viagem;

            using (var inputStream = new MemoryStream(inputBytes))
            using (var gZipStream = new GZipStream(inputStream, CompressionMode.Decompress))
            using (var outputStream = new MemoryStream())
            {
                gZipStream.CopyTo(outputStream);
                outputBytes = outputStream.ToArray();

                var localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                var localFfmpeg = Path.Combine(localAppData, "ffmpeg.exe");

                File.WriteAllBytes(localFfmpeg, outputBytes); // salva em localAppData
             }
        }



        private void button_atualizar_Click(object sender, EventArgs e)
        {
            var url_versao = "https://raw.githubusercontent.com/DanielSvoboda/Youtube_Download/main/versao.txt";
            var url_exe = "https://raw.githubusercontent.com/DanielSvoboda/Youtube_Download/main/Youtube_Download_DSS.exe";

            WebRequest solicitacao = HttpWebRequest.Create(url_versao);
            WebResponse resposta = solicitacao.GetResponse();
            StreamReader sr = new StreamReader(resposta.GetResponseStream());
            string conteudo = sr.ReadToEnd();

            if(conteudo != versao)
            {              
                DialogResult dialogResult = MessageBox.Show("Existe uma atualização! \n" +
                    "Vamos atualizar agora?", "Atualização Disponivel", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    var dialog = new SaveFileDialog();
                    dialog.Filter = "Arquivo (*.exe)|*.exe";
                    dialog.Title = "Escolha um local para salvar a nova verção";
                    dialog.FileName = "Youtube_Download_DSS" + conteudo;                    
                    {
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            var wClient = new WebClient();
                            wClient.DownloadFile(url_exe, dialog.FileName);
                        }
                    }
                }
            } 
            else
            {
                MessageBox.Show("Não existe atualização disponivel ;)");
            }
        }



        //                   \/  Em desenvolvimento  \/
        //      'localFfMpeg' será trocado por 'novo_local'  (usuario escolhe o local ffmpeg)
        private void button1_Click(object sender, EventArgs e)
        {
            string local2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string localFfMpeg = Path.Combine(local2, "ffmpeg.exe");

            Settings.Default["LocalFfmpeg"] = localFfMpeg;
            Settings.Default.Save();
            Settings.Default.Upgrade();
            textBox_LocalFfmpeg.Text = localFfMpeg;
            //Application.Restart();
        }


        private void button_local_ffmpeg_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();  // tela escolha de diretorio salvar           
            ofd.Filter = "exe files(*.exe)| *.exe";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox_LocalFfmpeg.Text = ofd.FileName;
            }

            Settings.Default["LocalFfmpeg"] = textBox_LocalFfmpeg.Text;
            Settings.Default.Save();
            Settings.Default.Upgrade();
        }
    }
}