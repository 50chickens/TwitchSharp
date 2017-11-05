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
        private List<string> playlist;

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

        public List<string> Playlist
        {
            get
            {
                return this.playlist;
            }
            set
            {
                this.playlist = value;
            }
        }

    }
}