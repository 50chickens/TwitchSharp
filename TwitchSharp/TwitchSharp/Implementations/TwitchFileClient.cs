using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchFileClient : ITwitchDataClient
    {
        
        public async Task<string> GetPostDataAsString(string location, Dictionary<string, string> postdata)
        {

            throw new NotImplementedException();


        }

        public async Task<string> GetDataAsString(string location)
        {

            string data;
            using (var reader = File.OpenText(location))
            {
                data = await reader.ReadToEndAsync();

            }

            return data;
        }

        public Task<Stream> GetDataAsStream(string location)
        {
            throw new NotImplementedException();
        }
    }
}

