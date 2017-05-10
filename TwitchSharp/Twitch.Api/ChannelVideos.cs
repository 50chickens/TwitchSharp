using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Api.ChannelVideos
{

    public class Channel
    {
        public string _id { get; set; }
        public string display_name { get; set; }
        public string name { get; set; }
    }

    public class Fps
    {
        public double chunked { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double medium { get; set; }
        public double mobile { get; set; }
    }

    public class Preview
    {
        public string large { get; set; }
        public string medium { get; set; }
        public string small { get; set; }
        public string template { get; set; }
    }

    public class Resolutions
    {
        public string chunked { get; set; }
        public string high { get; set; }
        public string low { get; set; }
        public string medium { get; set; }
        public string mobile { get; set; }
    }

    public class Large
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Medium
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Small
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Template
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Thumbnails
    {
        public List<Large> large { get; set; }
        public List<Medium> medium { get; set; }
        public List<Small> small { get; set; }
        public List<Template> template { get; set; }
    }

    public class Video
    {
        public string _id { get; set; }
        public long broadcast_id { get; set; }
        public string broadcast_type { get; set; }
        public Channel channel { get; set; }
        public string created_at { get; set; }
        public string description { get; set; }
        public string description_html { get; set; }
        public Fps fps { get; set; }
        public string game { get; set; }
        public string language { get; set; }
        public int length { get; set; }
        public Preview preview { get; set; }
        public string published_at { get; set; }
        public Resolutions resolutions { get; set; }
        public string status { get; set; }
        public string tag_list { get; set; }
        public Thumbnails thumbnails { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public string viewable { get; set; }
        public object viewable_at { get; set; }
        public int views { get; set; }
    }

    public class ChannelVideos
    {
        public int _total { get; set; }
        public List<Video> videos { get; set; }
    }

}
