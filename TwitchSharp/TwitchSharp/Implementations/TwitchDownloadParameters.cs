using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Implementations
{
    public class TwitchDownloadParameters

    {
        private string url;
        private string filename;

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }
        public string Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }
        
    }
}
