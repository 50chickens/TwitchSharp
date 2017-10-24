using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;
using TwitchSharp.Implementations;

namespace TwitchSharp
{
    public class DownloadFileCommandHandler : ICommandHandler<DownloadFileCommand>
    {
        private readonly ITwitchDataDownloadClient TwitchDataDownloadClient;
        event ProgressChangedHandler ProgressChanged;

        public DownloadFileCommandHandler(ITwitchDataDownloadClient twitchDataDownloadClient)
        {
            this.TwitchDataDownloadClient = twitchDataDownloadClient;
        }

        public async void HandleAsync(DownloadFileCommand command)
        {

            TwitchDataDownloadClient.ProgressChanged += TwitchDataClient_ProgressChanged;
            await TwitchDataDownloadClient.DownloadFile(command.Url, command.Location);


            // TODO: Logic here
        }

        private void TwitchDataClient_ProgressChanged(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage)
        {
            TriggerProgressChanged(totalFileSize, totalBytesDownloaded);
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

    }
}
