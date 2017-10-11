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

    public class GetTwitchVodQueryHandler : ITwitchQueryHandler<GetTwitchInfoVodQuery, Vod>
    {
        private readonly ITwitchClient client;

        public GetTwitchVodQueryHandler(ITwitchClient client)
        {
            this.client = client;


        }


        public async Task<Vod> HandleAsync(GetTwitchInfoVodQuery query)
        {
            if (query.VodUrl == null && query.VodId == "") throw new ApplicationException("both id and url are blank.");

            if (query.VodUrl != "" && query.VodId == null)

            {

                //string VodUrl = "https://www.twitch.tv/videos/" + vodid.ToString();

               
                //https://www.twitch.tv/videos/156832421

                List<string> strings = query.VodUrl.Split('/').ToList<string>();
                if (strings == null || strings.Count == 0)
                {
                    return null;
                }

                query.VodId = strings[4];


            }
            

            return await doQuery(query.Location, query.PropertyMapping);





        }

        private async Task<Vod> doQuery(string url, Dictionary<string, string> propertyMapping)
        {
            if (propertyMapping != null) return await this.client.GetTwitchData<Vod>(url, propertyMapping);

            return await this.client.GetTwitchData<Vod>(url);

        }
    }





}
