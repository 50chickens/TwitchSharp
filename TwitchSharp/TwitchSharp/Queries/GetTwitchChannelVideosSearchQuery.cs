using Twitch.Api.ChannelVideos;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchChannelVideosSearchQuery : ITwitchQuery<ChannelVideos>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchChannelVideosSearchQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        public int ChannelId { get; set; }

        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenChannelVideosUrl.Replace(@"{channelid}", this.ChannelId.ToString());

            }


        }

    }
}