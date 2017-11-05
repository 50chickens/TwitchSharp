using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetM3UTextQueryHandler : ITwitchQueryHandler<GetTwitchM3UTextQuery, string>
    {
        private readonly ITwitchClient client;
        

        public GetM3UTextQueryHandler(ITwitchClient client)
        {
            this.client = client;
            

        }



        public async Task<string> HandleAsync(GetTwitchM3UTextQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;
            

            string text = await this.client.GetTwitchDataAsString(query.Location);

            text = text.Replace("\"", "");

            text = text.Replace("\r", "");

            return text;



        }
    }





}
