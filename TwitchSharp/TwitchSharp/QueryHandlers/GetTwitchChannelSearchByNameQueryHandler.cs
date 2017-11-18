using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.SearchChannel;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchChannelSearchQueryHandler : ITwitchQueryHandler<GetTwitchChannelSearchByNameQuery, SearchChannels>
    {
        private readonly ITwitchClient client;


        public GetTwitchChannelSearchQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }

        public CancellationToken Token
        {
            get; set;
        }

        public async Task<SearchChannels> HandleAsync(GetTwitchChannelSearchByNameQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            return await this.client.GetTwitchData<SearchChannels>(query.Location);

        }
    }





}
