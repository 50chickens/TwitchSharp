using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.TopVideos;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{

    public class GetTwitchTopVideosQueryHandler : ITwitchQueryHandler<GetTwitchTopVideosQuery, Twitch.Api.TopVideos.TwitchTopVideos>
    {
        private readonly ITwitchClient client;

        public GetTwitchTopVideosQueryHandler(ITwitchClient client)
        {
            this.client = client;
        }

        

        public async Task<TwitchTopVideos> HandleAsync(GetTwitchTopVideosQuery query)
        {
            TwitchClient client = (TwitchClient)this.client;
            
            return await this.client.GetTwitchData<TwitchTopVideos>(query.Location);
            
        }
    }

    


    
}
