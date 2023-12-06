using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;
using System.Web.UI.WebControls.WebParts;

namespace Youtube_Download
{
    internal class Downloader
    {
        private HttpClient _client;
        private string _url;
        private string _filePath;
        private string _tempPath;
        private int _partCount;
        private long _fileSize;
        private System.Windows.Forms.ProgressBar _progressBar;
        private Form _form;

        public Downloader(string url, string filePath, string tempPath, System.Windows.Forms.ProgressBar progressBar)
        {
            _client = new HttpClient();
            _url = url;
            _filePath = filePath;
            _tempPath = tempPath;
            _progressBar = progressBar;
            _fileSize = GetFileSize(url);
            _partCount = CalculatePartCount(_fileSize, 1024 * 1024); // 1 MB por parte
        }

        public async Task DownloadFileAsync()
        {
            Console.WriteLine("_url: "+_url);
            Console.WriteLine("_filePath: " + _filePath);
            Console.WriteLine("_tempPath: " + _tempPath);
            Console.WriteLine("_fileSize: " + _fileSize);
            Console.WriteLine("_partCount: " + _partCount);



            List<Task> downloadTasks = new List<Task>();
            for (int i = 0; i < _partCount; i++)
            {
                downloadTasks.Add(DownloadPartAsync(i));
            }

            await Task.WhenAll(downloadTasks);
            CombineParts();
            //MessageBox.Show("Download concluído!");
        }

        private async Task DownloadPartAsync(int partIndex)
        {
            long start = partIndex * (_fileSize / _partCount);
            long end = (partIndex + 1) * (_fileSize / _partCount) - 1;
            if (partIndex == _partCount - 1)
            {
                end = _fileSize - 1; // Ajuste para a última parte
            }

            var range = new RangeHeaderValue(start, end);
            _client.DefaultRequestHeaders.Range = range;

            Console.WriteLine($"Iniciando o download da parte {partIndex + 1}/{_partCount}");


            var response = await _client.GetAsync(_url, HttpCompletionOption.ResponseHeadersRead);
            var content = await response.Content.ReadAsByteArrayAsync();


            // Garantir que a pasta temporária exista
            Directory.CreateDirectory(_tempPath);

            // Salvar a parte do arquivo na pasta temporária
            string partFileName = $"{Path.GetFileName(_filePath)}.part{partIndex}";
            string partPath = Path.Combine(_tempPath, partFileName);
            File.WriteAllBytes(partPath, content);

            Console.WriteLine($"Parte {partIndex + 1}/{_partCount} salva em {partPath}");

            _progressBar.Invoke(new Action(() =>
            {
                _progressBar.Value = (int)((partIndex + 1) / (float)_partCount * 100);
            }));
        }

        private void CombineParts()
        {
            using (var outputStream = File.Create(_filePath))
            {
                for (int i = 0; i < _partCount; i++)
                {
                    // Caminho da parte na pasta temporária
                    string partFileName = $"{Path.GetFileName(_filePath)}.part{i}";
                    string partPath = Path.Combine(_tempPath, partFileName);
                    var partBytes = File.ReadAllBytes(partPath);
                    outputStream.Write(partBytes, 0, partBytes.Length);
                    File.Delete(partPath); // Apagar a parte após a combinação
                    Console.WriteLine($"Parte {i + 1}/{_partCount} combinada");
                }
            }
        }

        private long GetFileSize(string url)
        {
            try
            {
                var request = WebRequest.Create(url);
                request.Method = "HEAD";

                using (var response = request.GetResponse())
                {
                    return response.ContentLength;
                }
            }
            catch (WebException ex)
            {
                // A WebException pode ser gerada se houver problemas ao acessar a URL
                Console.WriteLine($"Erro ao obter o tamanho do arquivo: {ex.Message}");
                return -1; // Ou outro valor padrão ou sinalizador para indicar erro
            }
            catch (Exception ex)
            {
                // Outras exceções inesperadas
                Console.WriteLine($"Erro inesperado ao obter o tamanho do arquivo: {ex.Message}");
                throw; // Re-throw para que a exceção seja propagada para cima, se necessário
            }
        }


        private int CalculatePartCount(long fileSize, int partSize)
        {
            return (int)Math.Ceiling(fileSize / (double)partSize);
        }
    }
}
