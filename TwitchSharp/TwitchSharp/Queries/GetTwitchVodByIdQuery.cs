using Twitch.Api.TopVideos;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    
    public class GetTwitchVodByIdQuery : ITwitchQuery<TwitchVod>
    {
        public string Id { get; set; }

        private ITwitchQueryOptions twitchClientOptions;


        

        public GetTwitchVodByIdQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }


        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenVodInfoUrl.Replace(@"{vid}", this.Id.ToString());

            }


        }

    }





}
