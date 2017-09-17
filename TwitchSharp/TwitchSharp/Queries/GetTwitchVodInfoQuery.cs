using Twitch.Api.Vod;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchVodInfoQuery : ITwitchQuery<Vod>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchVodInfoQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        public string VodUrl { get; set; }
        public string VodId { get; set; }

        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenVodInfoUrl.Replace(@"{vid}", this.VodId);

            }


        }

    }
}