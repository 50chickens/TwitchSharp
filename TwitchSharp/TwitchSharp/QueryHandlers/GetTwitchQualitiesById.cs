using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;
using TwitchSharp.Api;

namespace TwitchSharp.Implementations
{

    public class GetTwitchQualitiesById : ITwitchQueryHandler<GetTwitchVodQualitiesById, List<TwitchVideoQuality>>
    {
        private readonly ITwitchClient client;
        private readonly ITwitchFileProcessor fileprocessor;

        public GetTwitchQualitiesById(ITwitchClient client, ITwitchFileProcessor fileprocessor)
        {
            this.client = client;
            this.fileprocessor = fileprocessor;

        }

        public CancellationToken Token
        {
            get; set;
        }


        public async Task<List<TwitchVideoQuality>> HandleAsync(GetTwitchVodQualitiesById query)
        {

            TwitchClient client = (TwitchClient)this.client;

            string jsonResponse =  await client.GetTwitchDataAsString(query.Location);

            List<TwitchVideoQuality> qualityList = fileprocessor.GetVodQualities(jsonResponse);

            return qualityList;





        }
    }





}




