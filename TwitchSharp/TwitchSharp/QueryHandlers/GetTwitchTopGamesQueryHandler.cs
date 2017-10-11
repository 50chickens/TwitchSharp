using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.TopGames;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{

    public class GetTwitchTopGamesQueryHandler : ITwitchQueryHandler<GetTwitchTopGamesQuery, Twitch.Api.TopGames.TopGames>
    {
        private readonly ITwitchClient client;

        public GetTwitchTopGamesQueryHandler(ITwitchClient client)
        {
            this.client = client;
        }

        //public Task<TwitchTopGames> Handle(GetTwitchVodByIdQuery query)
        //{
        //    this.client.GetTwitchDataAsString(query.Id);


        //}

        public async Task<TopGames> HandleAsync(GetTwitchTopGamesQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            return await this.client.GetTwitchData<TopGames>(query.Location);

        }
        
    }

    


    
}
