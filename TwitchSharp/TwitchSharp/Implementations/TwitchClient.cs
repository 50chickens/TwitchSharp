using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchClient : ITwitchClient
    {
        private ITwitchHttpClient twitchWebServiceClient;
        

        public TwitchClient(ITwitchHttpClient twitchWebServiceClient)
        {
            this.twitchWebServiceClient = twitchWebServiceClient;
            
        }

        private ITwitchHttpClient TwitchWebServiceClient
        {
            get
            {
                return twitchWebServiceClient;

            }
            set { twitchWebServiceClient = value; }
        }
        

        public async Task<string> GetTwitchDataAsString(string url)
        {
            return await twitchWebServiceClient.GetDataAsString(url);

        }
        public async Task<T> GetTwitchData<T>(string url)
        {

            string data = await this.GetTwitchDataAsString(url);
            return JsonConvert.DeserializeObject<T>(data);


        }
    }
}
