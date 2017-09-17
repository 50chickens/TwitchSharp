using Twitch.Api.SearchChannel;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchChannelSearchByNameQuery : ITwitchQuery<SearchChannels>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchChannelSearchByNameQuery(ITwitchQueryOptions twitchClientOptions)
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