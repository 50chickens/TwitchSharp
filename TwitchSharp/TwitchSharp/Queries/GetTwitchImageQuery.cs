using System.Collections.Generic;
using System.Drawing;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchImageQuery : ITwitchQuery<Image>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchImageQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        public string ImageUrl { get; set; }

        public string Location
        {
            get
            {
                return this.ImageUrl;

            }


        }

    }
}