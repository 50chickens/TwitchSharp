using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class M3UQueryHandler : ITwitchQueryHandler<GetTwitchM3UQuery, M3U>
    {
        private readonly ITwitchClient client;


        public M3UQueryHandler(ITwitchClient client)
        {
            this.client = client;

        }



        public async Task<M3U> HandleAsync(GetTwitchM3UQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;
            //string t = await this.client.GetTwitchDataAsString(query.Url);

            //Vod vod = await this.client.GetTwitchData<Vod>(query.Url);

            string text = await this.client.GetTwitchDataAsString(query.Url);

            //M3U8 m3u8 = new M3U8(text, "chunked");

            return new M3U()
            {
                Text = text
            };
            //return m3u8;

        }
    }





}
