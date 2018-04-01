using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Api;
using TwitchSharp.Implementations;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchFileProcessor
    {
        List<TwitchVideoQuality> GetVodQualities(string vodInfoResponse);
        List<string> GetM3U8List(string text);
        List<string> GetPlaylistFiles(string m3utext);

        List<TwitchDownload> GetDownloadsFromPlaylist(List<string> playlist, string url, string filename, string quality);
        M3U8 GetM3U8(string text);
    }
}
