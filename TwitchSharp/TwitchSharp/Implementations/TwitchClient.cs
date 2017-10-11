using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchClient : ITwitchClient
    {
        private ITwitchDataClient twitchDataClient;


        public TwitchClient(ITwitchDataClient twitchDataClient)
        {
            this.twitchDataClient = twitchDataClient;

        }

        private ITwitchDataClient TwitchDataClient
        {
            get
            {
                return twitchDataClient;

            }
            set { twitchDataClient = value; }
        }


        public async Task<string> GetTwitchDataAsString(string location)
        {
            return await twitchDataClient.GetDataAsString(location);

        }

        public async Task<Stream> GetTwitchDataAsStream(string location)
        {
            return await twitchDataClient.GetDataAsStream(location);

        }

        public async Task<T> GetTwitchData<T>(string location)
        {

            string data = await this.GetTwitchDataAsString(location);
            return JsonConvert.DeserializeObject<T>(data);


        }


        public async Task<T> GetTwitchData<T>(string url, Dictionary<string, string> propertyMappings)
        {
            JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings();

            CustomContractResolver customContractResolver = new CustomContractResolver(propertyMappings);

            jsonSerializerSettings.ContractResolver = customContractResolver;

            string data = await this.GetTwitchDataAsString(url);
            return JsonConvert.DeserializeObject<T>(data, jsonSerializerSettings);

        }

        
    }


}
