using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetM3U8QueryHandler : ITwitchQueryHandler<GetTwitchM3U8Query, M3U8>
    {
        private readonly ITwitchFileProcessor iTwitchFileProcessor;
        

        public GetM3U8QueryHandler(ITwitchFileProcessor iTwitchFileProcessor)
        {
            this.iTwitchFileProcessor = iTwitchFileProcessor;
            

        }

        public CancellationToken Token
        {
            get; set;
        }


        public async Task<M3U8> HandleAsync(GetTwitchM3U8Query query)
        {




            M3U8 m3u8 = this.iTwitchFileProcessor.GetM3U8(query.Text);

            

            return m3u8;



        }

        
    }





}
