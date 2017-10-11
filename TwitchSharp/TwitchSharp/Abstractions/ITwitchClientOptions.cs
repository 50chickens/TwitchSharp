using System.Collections.Generic;
using System.Threading.Tasks;

namespace TwitchSharp.Abstractions
{
    public interface ITwitchClientOptions
    {
        string GetLocation(string key);
        
    }
}