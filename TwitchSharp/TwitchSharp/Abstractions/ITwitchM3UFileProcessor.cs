using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchM3UFileProcessor
    {
        List<M3U8> GetM3U8List(M3U m3u);
    }

    
}
