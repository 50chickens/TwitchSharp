using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Api.Vod
{

    public class Preview
    {
        public string small { get; set; }
        public string medium { get; set; }
        public string large { get; set; }
        public string template { get; set; }
    }

    public class Small
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Medium
    {
        public string type { get; set; }
        public string url { get; set; }
    }

    public class Large
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
        public List<Small> small { get; set; }
        public List<Medium> medium { get; set; }
        public List<Large> large { get; set; }
        public List<Template> template { get; set; }
    }

    
   // [JsonConverter(typeof(FpsConverter))]
    public class Fps
    {
        public double audio_only { get; set; }

        
        //[JsonConverter(typeof(FpsConverter))]
        public double chunked { get; set; }

        //[JsonProperty(PropertyName = "720p30")]
        //[JsonConverter(typeof(FpsConverter))]

        public double high { get; set; }

       // [JsonProperty(PropertyName = "480p30")]
       // [JsonConverter(typeof(FpsConverter))]

        public double low { get; set; }

       // [JsonProperty(PropertyName = "360p30")]
       // [JsonConverter(typeof(FpsConverter))]
        public double medium { get; set; }

       // [JsonProperty(PropertyName = "160p30")]
       // [JsonConverter(typeof(FpsConverter))]
        public double mobile {get; set;}
    }
    // , , , 
    public class Resolutions
    {

        public string chunked { get; set; }

        //[JsonProperty(PropertyName = "720p30")]
        public string high { get; set; }

        //[JsonProperty(PropertyName = "480p30")]
        public string low { get; set; }

        //[JsonProperty(PropertyName = "360p30")]
        public string medium { get; set; }

        //[JsonProperty(PropertyName = "160p30")]
        public string mobile { get; set; }
    }

    public class Channel
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string display_name { get; set; }
    }

        //[JsonConverter(typeof(VodInfoConverter))]

    public class Vod
    {
        public string title { get; set; }
        public object description { get; set; }
        public object description_html { get; set; }
        public long broadcast_id { get; set; }
        public string broadcast_type { get; set; }
        public string status { get; set; }
        public string tag_list { get; set; }
        public int views { get; set; }
        public string url { get; set; }
        public string language { get; set; }
        public string created_at { get; set; }
        public string viewable { get; set; }
        public object viewable_at { get; set; }
        public string published_at { get; set; }
        public string _id { get; set; }
        public string recorded_at { get; set; }
        public string game { get; set; }
        public float length { get; set; }
        public Preview preview { get; set; }
        public string animated_preview_url { get; set; }
        public Thumbnails thumbnails { get; set; }
        public Fps fps { get; set; }
        public Resolutions resolutions { get; set; }
        public Channel channel { get; set; }
    }


}
