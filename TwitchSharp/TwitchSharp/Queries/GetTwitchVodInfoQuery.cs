using System.Collections.Generic;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchInfoVodQuery : ITwitchQuery<Vod>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchInfoVodQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        //public Dictionary<string, string> PropertyMapping { get; set; }

        //public string VodUrl { get; set; }
        public string VodId { get; set; }

        public string Location
        {
            get
            {
                return this.twitchClientOptions.KrakenVodInfoUrl.Replace(@"{vid}", this.VodId);

            }


        }

    }
}