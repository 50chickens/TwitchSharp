using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.ChannelVideos;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchChannelVideosSearchQueryHandler : ITwitchQueryHandler<GetTwitchChannelVideosSearchQuery, ChannelVideos>
    {
        private readonly ITwitchClient client;


        public GetTwitchChannelVideosSearchQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }



        public async Task<ChannelVideos> HandleAsync(GetTwitchChannelVideosSearchQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            return await this.client.GetTwitchData<ChannelVideos>(query.Url);

        }

        
    }





}
