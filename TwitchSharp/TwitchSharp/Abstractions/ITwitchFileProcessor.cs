using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Api;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchFileProcessor
    {
        List<TwitchVideoQuality> GetVodQualities(string vodInfoResponse);
    }
}
