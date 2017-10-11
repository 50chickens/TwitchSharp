using System.Collections.Generic;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;
using TwitchSharp.Api;

namespace TwitchSharp.Implementations
{
    public class GetTwitchVodQualitiesById : ITwitchQuery<List<TwitchVideoQuality>>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchVodQualitiesById(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

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