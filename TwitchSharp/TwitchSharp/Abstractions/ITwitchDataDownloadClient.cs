using System.Threading;
using System.Threading.Tasks;
using TwitchSharp.Implementations;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchDataDownloadClient
    {
        event ProgressChangedHandler ProgressChanged;

        Task DownloadFile(string url, string folder, string filename, bool useSubfolder, string subfolder, CancellationToken token);
    }
}