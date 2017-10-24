namespace Twitch.Api
{
    public class M3U8
    {
        private string xmedia;
        private string xstreaminf;
        private string url;
        private string name;
        private string resolution;
        private string video;
        private int? fps;

        public M3U8(string xMedia, string xStreamInf, string url)
        {
            this.xmedia = xMedia;
            this.xstreaminf = xStreamInf;
            this.url = url;
        }

        //#EXT-X-MEDIA:TYPE=VIDEO,GROUP-ID="480p30",NAME="480p30",AUTOSELECT=YES,DEFAULT=YES
        //#EXT-X-STREAM-INF:PROGRAM-ID=1,BANDWIDTH=1407910,CODECS="avc1.4D4D1F,mp4a.40.2",RESOLUTION="852x480",VIDEO="480p30"
        //http://vod178-ttvnw.akamaized.net/6bdd1299934c0ad40d89_zlive_25676860544_673474276/480p30/index-dvr.m3u8

        
        public string Url
        {
            get
            {
                return this.url;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public string Video
        {
            get
            {
                return this.video;
            }
            set
            {
                this.video = value;
            }
        }

        public int? Fps
        {
            get
            {
                return this.fps;
            }
            set
            {
                this.fps = value;
            }
        }

        public string Resolution
        {
            get
            {
                return this.resolution;
            }
           set
            {
                this.resolution = value;
            }
        }


    }
}