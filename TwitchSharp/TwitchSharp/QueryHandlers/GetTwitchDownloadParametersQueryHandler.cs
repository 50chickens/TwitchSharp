using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetTwitchDownloadParametersQueryHandler : ITwitchQueryHandler<GetTwitchDownloadParametersQuery, List<TwitchDownloadParameters>>
    {
        private readonly ITwitchFileProcessor iTwitchFileProcessor;


        public GetTwitchDownloadParametersQueryHandler(ITwitchFileProcessor iTwitchFileProcessor)
        {
            this.iTwitchFileProcessor = iTwitchFileProcessor;

        }

        

        public async Task<List<TwitchDownloadParameters>> HandleAsync(GetTwitchDownloadParametersQuery query)
        {

            List <TwitchDownloadParameters> downloadParameters;



            //List<string> playlist, string url, string filename, string incquality, string quality

            downloadParameters = this.iTwitchFileProcessor.GetDownloadParametersFromPlaylist(query.Playlist, query.Url, query.Folder, query.SourceQuality, query.DestinationQuality);

            return downloadParameters;
            
            

        }
    }





}
