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

    public class GetM3U8ListQueryHandler : ITwitchQueryHandler<GetTwitchM3U8ListQuery, List<string>>
    {
        private readonly ITwitchFileProcessor iTwitchFileProcessor;


        public GetM3U8ListQueryHandler(ITwitchFileProcessor iTwitchFileProcessor)
        {
            this.iTwitchFileProcessor = iTwitchFileProcessor;

        }

        public CancellationToken Token
        {
            get;
            set;
            
        }

       

        public async Task<List<string>> HandleAsync(GetTwitchM3U8ListQuery query)
        {

            List<string> M3u8list;

            
            M3u8list = this.iTwitchFileProcessor.GetM3U8List(query.Text);

            return M3u8list;
            
            

        }
    }





}
