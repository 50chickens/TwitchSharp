using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Implementations
{
    public class TwitchHttpClientOptions : ITwitchHttpClientOptions
    {
        public string clientid { get; set; }
        public string clientsecret { get; set; }
    }
}
