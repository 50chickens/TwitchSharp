using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchHttpClient : ITwitchHttpClient
    {
        private HttpClient httpClient;
        private ITwitchHttpClientOptions twitchHttpClientOptions;

        public TwitchHttpClient(HttpClient httpClient, ITwitchHttpClientOptions twitchHttpClientOptions)
        {
            this.httpClient = httpClient;
            this.twitchHttpClientOptions = twitchHttpClientOptions;
           ConfigureClient();

        }

        public void ConfigureClient()
        {
            if (twitchHttpClientOptions.clientid == "") throw new NullReferenceException("clientid");
            

            httpClient.DefaultRequestHeaders.Add("Accept", "application/vnd.twitchtv.v5+json");
            httpClient.DefaultRequestHeaders.Add("Client-ID", twitchHttpClientOptions.clientid);
            

        }


        internal async Task<string> GetPostDataAsString<T>(string url, T postobject)
        {
            HttpResponseMessage response;

            //SetupHttpPost();
        
            response = await httpClient.PostAsJsonAsync<T>(url, postobject);

            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;
        }

        private void SetupHttpPost()
        {
            if (!httpClient.DefaultRequestHeaders.AcceptEncoding.Contains(new StringWithQualityHeaderValue("application/json")))
            {
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            }
        }

        public async Task<string> GetPostDataAsString(string url, Dictionary<string, string> postdata)
        {

            HttpResponseMessage response;

            response = await httpClient.PostAsync(url, new FormUrlEncodedContent(postdata));
            
            var responseContent = await response.Content.ReadAsStringAsync();

            return responseContent;


        }

        public async Task<string> GetDataAsString(string url)
        {


            return await httpClient.GetStringAsync(url);


        }

    }
}

