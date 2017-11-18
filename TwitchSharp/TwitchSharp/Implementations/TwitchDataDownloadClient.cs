using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchDataDownloadClient : ITwitchDataDownloadClient, IDisposable
    {
        private string url;
        private string localLocationToSave;

        private HttpClient httpClient;

        

        public event ProgressChangedHandler ProgressChanged;

        public async Task DownloadFile(string url, string folder, string filename, bool CreateSubfolder, string subFolderName, CancellationToken token)
        {
            
            if (token.IsCancellationRequested)
            {
                token.ThrowIfCancellationRequested();
            }
            this.httpClient = new HttpClient();

            this.url = url;
            
            if (CreateSubfolder && subFolderName != "")
            {
                string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

                foreach (char c in invalid)
                {
                    subFolderName = subFolderName.Replace(c.ToString(), "");
                }

                if (!Directory.Exists(folder + @"\" + subFolderName))
                {
                    Directory.CreateDirectory(folder + @"\" + subFolderName);

                }

                this.localLocationToSave =  folder + @"\" + subFolderName + @"\" + filename;
            }

            else
            {
                this.localLocationToSave = folder + @"\" + filename;
            }
            using (var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                await DownloadFileFromHttpResponseMessage(response);

        }

        private async Task DownloadFileFromHttpResponseMessage(HttpResponseMessage response)
        {
            response.EnsureSuccessStatusCode();

            var totalBytes = response.Content.Headers.ContentLength;

            using (var contentStream = await response.Content.ReadAsStreamAsync())
                await ProcessContentStream(totalBytes, contentStream);
        }

        private async Task ProcessContentStream(long? totalDownloadSize, Stream contentStream)
        {
            var totalBytesRead = 0L;
            var readCount = 0L;
            var buffer = new byte[8192];
            var isMoreToRead = true;

            using (var fileStream = new FileStream(localLocationToSave, FileMode.Create, FileAccess.Write, FileShare.None, 8192, true))
            {
                do
                {
                    var bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length);
                    if (bytesRead == 0)
                    {
                        isMoreToRead = false;
                        TriggerProgressChanged(totalDownloadSize, totalBytesRead);
                        continue;
                    }

                    await fileStream.WriteAsync(buffer, 0, bytesRead);

                    totalBytesRead += bytesRead;
                    readCount += 1;

                    if (readCount % 100 == 0)
                        TriggerProgressChanged(totalDownloadSize, totalBytesRead);
                }
                while (isMoreToRead);
            }
        }

        private void TriggerProgressChanged(long? totalDownloadSize, long totalBytesRead)
        {
            if (ProgressChanged == null)
                return;

            double? progressPercentage = null;
            if (totalDownloadSize.HasValue)
                progressPercentage = Math.Round((double)totalBytesRead / totalDownloadSize.Value * 100, 2);

            ProgressChanged(totalDownloadSize, totalBytesRead, progressPercentage);
        }

        public void Dispose()
        {
            httpClient?.Dispose();
        }
    }


}
