using System;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchM3UTextQuery : ITwitchQuery<string>
    {
        private string text;
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchM3UTextQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

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

        private string url;
        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                this.url = value;
            }
        }
        public string Location
        {
            get
            {
                return url;

            }


        }


    }
}