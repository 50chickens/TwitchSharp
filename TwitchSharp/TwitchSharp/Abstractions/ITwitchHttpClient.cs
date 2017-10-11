using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchDataClient
    {
        Task<Stream> GetDataAsStream(string location);
        Task<string> GetDataAsString(string location);
        Task<string> GetPostDataAsString(string location, Dictionary<string, string> postdata);
    }
}
