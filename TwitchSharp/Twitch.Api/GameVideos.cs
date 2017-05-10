using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Api.GameVideos
{

    public class Links
    {
        public string self { get; set; }
        public string next { get; set; }
    }

    public class Fps
    {
        public double audio_only { get; set; }
        public double medium { get; set; }
        public double mobile { get; set; }
        public double low { get; set; }
        public double chunked { get; set; }
        public double? high { get; set; }
    }

    public class Resolutions
    {
        public string medium { get; set; }
        public string mobile { get; set; }
        public string low { get; set; }
        public string chunked { get; set; }
        public string high { get; set; }
    }

    public class Links2
    {
        public string self { get; set; }
        public string channel { get; set; }
    }

    public class Channel
    {
        public string name { get; set; }
        public string display_name { get; set; }
    }

    public class Video
    {
        public string title { get; set; }
        public string description { get; set; }
        public object broadcast_id { get; set; }
        public string status { get; set; }
        public string tag_list { get; set; }
        public string _id { get; set; }
        public string recorded_at { get; set; }
        public string game { get; set; }
        public int length { get; set; }
        public string delete_at { get; set; }
        public bool is_muted { get; set; }
        public string preview { get; set; }
        public object thumbnails { get; set; }
        public string url { get; set; }
        public int views { get; set; }
        public Fps fps { get; set; }
        public Resolutions resolutions { get; set; }
        public string broadcast_type { get; set; }
        public string created_at { get; set; }
        public Links2 _links { get; set; }
        public Channel channel { get; set; }
    }


    public class TopGameVideos
    {
        public Links _links { get; set; }
        public List<Video> videos { get; set; }
        public string game { get; set; }
    }

}
