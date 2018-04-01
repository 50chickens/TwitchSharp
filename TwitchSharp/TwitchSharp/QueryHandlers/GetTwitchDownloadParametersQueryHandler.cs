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

    public class GetTwitchDownloadParametersQueryHandler : ITwitchQueryHandler<GetTwitchDownloadQuery, List<TwitchDownload>>
    {
        private readonly ITwitchFileProcessor iTwitchFileProcessor;


        public GetTwitchDownloadParametersQueryHandler(ITwitchFileProcessor iTwitchFileProcessor)
        {
            this.iTwitchFileProcessor = iTwitchFileProcessor;

        }

        public CancellationToken Token
        {
            get;set;
        }

        

        public async Task<List<TwitchDownload>> HandleAsync(GetTwitchDownloadQuery query)
        {

            List <TwitchDownload> downloadParameters;

            

            //List<string> playlist, string url, string filename, string incquality, string quality

            downloadParameters = this.iTwitchFileProcessor.GetDownloadsFromPlaylist(query.Playlist, query.Url, query.Folder, query.Quality);

            return downloadParameters;
            
            

        }
    }





}
