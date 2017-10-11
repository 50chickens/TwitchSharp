using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.LiveStreams;
using Twitch.Api.TopVideos;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{

    public class GetTwitchLiveStreamsQueryHandler : ITwitchQueryHandler<GetTwitchLiveStreamsQuery, LiveStreams>
    {
        private readonly ITwitchClient client;
        

        public GetTwitchLiveStreamsQueryHandler(ITwitchClient client)
        {
            this.client = client;
            
        }

        

        public async Task<LiveStreams> HandleAsync(GetTwitchLiveStreamsQuery query)
        {
            
            TwitchClient client = (TwitchClient)this.client;
            
            return await this.client.GetTwitchData<LiveStreams>(query.Location);
            
        }
    }

    


    
}
