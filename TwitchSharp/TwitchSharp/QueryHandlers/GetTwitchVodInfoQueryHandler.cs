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

    public class GetTwitchVodInfoQueryHandler : ITwitchQueryHandler<GetTwitchInfoVodQuery, Vod>
    {
        private readonly ITwitchClient client;

        public GetTwitchVodInfoQueryHandler(ITwitchClient client)
        {
            this.client = client;


        }


        public async Task<Vod> HandleAsync(GetTwitchInfoVodQuery query)
        {
            if (query.VodId == "") throw new ApplicationException("id is blank.");

            return await this.client.GetTwitchData<Vod>(query.Location);


        }

        private async Task<Vod> doQuery(string url, Dictionary<string, string> propertyMapping)
        {
            if (propertyMapping != null) return await this.client.GetTwitchData<Vod>(url, propertyMapping);

            return await this.client.GetTwitchData<Vod>(url);

        }
    }





}
