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
        private string localFilenameToSave;
        private string localFolderToSave;

        private HttpClient httpClient;
        private bool appendToFile;
        private string appendFileName;
        private bool createFile;

        public event ProgressChangedHandler ProgressChanged;

        public async Task DownloadFile(string url, string folder, string filename, bool CreateSubfolder, string subFolderName, CancellationToken token, bool appendToFile, string appendFileName, bool createFile)
        {

            if (token.IsCancellationRequested)
            {
                token.ThrowIfCancellationRequested();
            }
            this.httpClient = new HttpClient();

            this.url = url;
            this.appendToFile = appendToFile;
            this.appendFileName = appendFileName;
            this.createFile = createFile;

            if (CreateSubfolder && subFolderName != "")
            {
                this.localFolderToSave = folder + @"\" + GetSafeName(subFolderName) + @"\";
            }

            else
            {
                this.localFolderToSave = folder + @"\";
            }

            if (appendToFile)
            {
                this.localFilenameToSave = this.localFolderToSave + appendFileName;

            }
            else
            {
                this.localFilenameToSave = this.localFolderToSave + filename;

            }

            if (CreateSubfolder && !Directory.Exists(localFolderToSave))
            {
                Directory.CreateDirectory(localFolderToSave);

            }

            using (var response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead))
                await DownloadFileFromHttpResponseMessage(response, token);

        }

        private string GetSafeName(string name)
        {
            string invalid = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());

            foreach (char c in invalid)
            {
                name = name.Replace(c.ToString(), "");
            }

            return name;
        }

        private async Task DownloadFileFromHttpResponseMessage(HttpResponseMessage response, CancellationToken token)
        {
            response.EnsureSuccessStatusCode();

            var totalBytes = response.Content.Headers.ContentLength;

            using (var contentStream = await response.Content.ReadAsStreamAsync())
                await ProcessContentStream(totalBytes, contentStream, token);
        }

        private async Task ProcessContentStream(long? totalDownloadSize, Stream contentStream, CancellationToken token)
        {
            var totalBytesRead = 0L;
            var readCount = 0L;
            var buffer = new byte[8192];
            var isMoreToRead = true;

            FileMode fileMode;

            if (createFile || !appendToFile)
            {
                fileMode = FileMode.Create;
                
            }
            else
            {
                fileMode = FileMode.Append;
            }

            using (var fileStream = new FileStream(localFilenameToSave, fileMode, FileAccess.Write, FileShare.None, 8192, true))
            {
                do
                {
                    if (token.IsCancellationRequested)
                    {
                        token.ThrowIfCancellationRequested();
                    }
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
