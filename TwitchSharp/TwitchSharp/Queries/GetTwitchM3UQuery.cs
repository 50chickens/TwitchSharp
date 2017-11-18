using System;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchM3UQuery : ITwitchQuery<M3U>
    {
        private ITwitchQueryOptions twitchClientOptions;
        private string text;
       
        private string baseurl;
        private string location;
        

        public GetTwitchM3UQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        public string BaseUrl
        {
            get
            {
                return baseurl;
            }

            set
            {
                baseurl = value;
            }
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        

        public string Location
        {
            get
            {
                return location;
            }
        }
    }
}