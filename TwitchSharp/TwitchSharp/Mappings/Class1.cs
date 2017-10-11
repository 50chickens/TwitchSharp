using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Mappings
{
    class VodMappings
    {
        public VodMappings()
        {
            this.PropertyMappings = new Dictionary<string, string>
        {
            {"Mobile", "160p30"},
            {"Low", "360p30"},
            {"Medium", "480p30"},
            {"High", "720p30"},
            {"Chunked", "chunked" }
            
        };
        }

        public Dictionary<string, string> PropertyMappings { get; private set; }
    }
}
