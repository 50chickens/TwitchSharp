using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using Twitch.Api.Channel;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class VodInfoQueryHandler : ITwitchQueryHandler<GetTwitchVodInfoQuery, Vod>
    {
        private readonly ITwitchClient client;


        public VodInfoQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }



        public async Task<Vod> HandleAsync(GetTwitchVodInfoQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;
            //string t = await this.client.GetTwitchDataAsString(query.Url);
            
            //Vod vod = await this.client.GetTwitchData<Vod>(query.Url);
            return await this.client.GetTwitchData<Vod>(query.Url);

        }
    }





}
