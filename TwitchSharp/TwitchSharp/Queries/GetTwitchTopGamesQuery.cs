using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchTopGamesQuery : ITwitchQuery<Twitch.Api.TopGames.TopGames>
    {
        
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchTopGamesQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        public int Limit { get; set; }

        public string Location
        {
            get
            {
                return this.twitchClientOptions.KrakenTopGamesUrl.Replace(@"{limit}", this.Limit.ToString());

            }


        }

    }

    


    
}
