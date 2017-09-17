using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.SearchChannel;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchChannelSearchQueryHandler : ITwitchQueryHandler<GetTwitchChannelSearchQuery, SearchChannels>
    {
        private readonly ITwitchClient client;


        public GetTwitchChannelSearchQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }



        public async Task<SearchChannels> HandleAsync(GetTwitchChannelSearchQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            return await this.client.GetTwitchData<SearchChannels>(query.Url);

        }
    }





}
