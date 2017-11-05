using System;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchM3U8Query : ITwitchQuery<M3U8>
    {
        private string text;
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchM3U8Query(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        public string Location
        {
            get
            {
                throw new NotImplementedException();
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