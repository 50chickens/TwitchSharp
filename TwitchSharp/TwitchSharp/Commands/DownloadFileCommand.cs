using TwitchSharp.Implementations;

namespace TwitchSharp
{

    public class DownloadFileCommand
    {
        public string Location { get; set; }

        public string Url { get; set; }

        //public delegate void ProgressChangedHandler(long? totalFileSize, long totalBytesDownloaded, double? progressPercentage);

        public event ProgressChangedHandler ProgressChanged;

    }

}