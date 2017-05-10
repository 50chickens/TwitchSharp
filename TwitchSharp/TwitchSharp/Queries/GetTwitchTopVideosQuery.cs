using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchTopVideosQuery : ITwitchQuery<Twitch.Api.TopVideos.TwitchTopVideos>
    {
        private ITwitchQueryOptions twitchClientOptions;

        
        public int Limit { get; set; }

        public GetTwitchTopVideosQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }


        public string Url
        {
            get
            {
                return this.twitchClientOptions.KrakenTopVideosUrl.Replace(@"{limit}", this.Limit.ToString());

            }


        }

    }

    


    
}
