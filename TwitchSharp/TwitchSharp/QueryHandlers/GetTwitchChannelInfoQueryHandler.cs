using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.Channel;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchChannelInfoQueryHandler : ITwitchQueryHandler<GetTwitchChannelInfoQuery, ChannelInfo>
    {
        private readonly ITwitchClient client;


        public GetTwitchChannelInfoQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }

        public CancellationToken Token
        {
            get; set;
        }


        public async Task<ChannelInfo> HandleAsync(GetTwitchChannelInfoQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            return await this.client.GetTwitchData<ChannelInfo>(query.Location);

        }
    }





}
