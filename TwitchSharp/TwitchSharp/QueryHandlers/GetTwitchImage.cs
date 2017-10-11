using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;
using TwitchSharp.Api;

namespace TwitchSharp.Implementations
{

    public class GetTwitchImage : ITwitchQueryHandler<GetTwitchImageQuery, Image>
    {
        private readonly ITwitchClient client;
        private readonly ITwitchFileProcessor fileprocessor;

        public GetTwitchImage(ITwitchClient client, ITwitchFileProcessor fileprocessor)
        {
            this.client = client;
            this.fileprocessor = fileprocessor;

        }



        public async Task<Image> HandleAsync(GetTwitchImageQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            Stream imageStream =  await client.GetTwitchDataAsStream(query.Location);

            //List<TwitchVideoQuality> qualityList = fileprocessor.GetVodQualities(jsonResponse);

            Image i = Image.FromStream(imageStream);

            return i;





        }
    }





}




