using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twitch.Api;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{

    public class GetM3UQueryHandler : ITwitchQueryHandler<GetTwitchM3UQuery, M3U>
    {
        private readonly ITwitchFileProcessor iTwitchFileProcessor;


        public GetM3UQueryHandler(ITwitchFileProcessor iTwitchFileProcessor)
        {
            this.iTwitchFileProcessor = iTwitchFileProcessor;

        }

        

        public async Task<M3U> HandleAsync(GetTwitchM3UQuery query)
        {

            M3U m3u = new M3U();

            m3u.Text = query.Text;
            m3u.Playlist = this.iTwitchFileProcessor.GetPlaylistFiles(query.Text);

            return m3u;
            
            

        }
    }





}
