using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Api
{
    public class M3U
    {
        private string url;
        private string text;



        // public List<M3U8> M3U8s;

        public string Url
        {
            get
            {
                return this.url;
            }
        }

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }


    }
}