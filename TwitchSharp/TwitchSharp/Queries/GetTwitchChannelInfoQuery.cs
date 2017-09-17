using Twitch.Api.Channel;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchChannelInfoQuery : ITwitchQuery<ChannelInfo>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchChannelInfoQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        public string ChannelId { get; set; }

        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenChannelInfoUrl.Replace(@"{channelid}", this.ChannelId);

            }


        }

    }
}