using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchHttpClient
    {
        Task<string> GetDataAsString(string url);
        Task<string> GetPostDataAsString(string url, Dictionary<string, string> postdata);
    }
}
