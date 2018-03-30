using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;
using TwitchSharp.Api;

namespace TwitchSharp.Implementations
{

    public class GetTwitchImageHandler : ITwitchQueryHandler<GetTwitchImageQuery, Image>
    {
        private readonly ITwitchClient client;
        

        public GetTwitchImageHandler(ITwitchClient client)
        {
            this.client = client;
            
        }

        public CancellationToken Token
        {
            get; set;
        }


        public async Task<Image> HandleAsync(GetTwitchImageQuery query)
        {

            TwitchClient client = (TwitchClient)this.client;

            Stream imageStream =  await client.GetTwitchDataAsStream(query.Location);

            Image i = Image.FromStream(imageStream);

            return i;





        }
    }





}




