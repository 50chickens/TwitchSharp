using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.ChannelVideos;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchChannelVideosByIdQueryHandler : ITwitchQueryHandler<GetTwitchChannelVideosByIdQuery, ChannelVideos>
    {
        private readonly ITwitchClient client;


        public GetTwitchChannelVideosByIdQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }

        public CancellationToken Token
        {
            get; set;
        }


        public async Task<ChannelVideos> HandleAsync(GetTwitchChannelVideosByIdQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            return await this.client.GetTwitchData<ChannelVideos>(query.Location);

        }

        
    }





}
