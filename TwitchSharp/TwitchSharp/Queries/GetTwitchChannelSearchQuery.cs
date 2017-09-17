using Twitch.Api.SearchChannel;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchChannelSearchQuery : ITwitchQuery<SearchChannels>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchChannelSearchQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        public string ChannelName { get; set; }

        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenSearchChannelsUrl.Replace(@"{query}", this.ChannelName.ToString());

            }


        }

    }
}