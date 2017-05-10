using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.TopVideos;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{

    public class GetTwitchVodByIdQueryHandler : ITwitchQueryHandler<GetTwitchVodByIdQuery, TwitchVod>
    {
        private readonly ITwitchClient client;

        public GetTwitchVodByIdQueryHandler(ITwitchClient client)
        {
            this.client = client;
        }

       
        public async Task<TwitchVod> HandleAsync(GetTwitchVodByIdQuery query)
        {
            
            
            return await this.client.GetTwitchData<TwitchVod>(query.Id);
            

        }

    
        
    }

    


    
}
