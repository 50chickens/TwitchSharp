using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Implementations
{
    public class TwitchDownloadQueue
    {
        private string folder;
        private List<TwitchDownload> downloadParameters;


        public string Folder
        {
            get
            {
                return folder;
            }

            set
            {
                folder = value;
            }
        }

        public List<TwitchDownload> DownloadParameters
        {
            get
            {
                return downloadParameters;
            }

            set
            {
                downloadParameters = value;
            }
        }

        
    }
}
