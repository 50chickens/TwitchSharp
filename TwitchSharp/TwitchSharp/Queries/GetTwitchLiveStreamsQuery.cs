using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchLiveStreamsQuery : ITwitchQuery<Twitch.Api.LiveStreams.LiveStreams>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchLiveStreamsQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        public int Limit { get; set; }

        public string Location
        {
            get
            {
                return this.twitchClientOptions.KrakenLiveStreamsUrl.Replace(@"{limit}", this.Limit.ToString());

            }


        }

    }
}
