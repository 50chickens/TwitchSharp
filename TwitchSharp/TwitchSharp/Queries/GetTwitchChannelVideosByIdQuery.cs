using Twitch.Api.ChannelVideos;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchChannelVideosByIdQuery : ITwitchQuery<ChannelVideos>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchChannelVideosByIdQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        public string ChannelId { get; set; }

        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenChannelVideosUrl.Replace(@"{channelid}", this.ChannelId.ToString());

            }


        }

    }
}