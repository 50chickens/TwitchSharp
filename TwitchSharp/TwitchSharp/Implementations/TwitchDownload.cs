using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Implementations
{
    public class TwitchDownload
    {
        private string folder;
        private TwitchDownloadParameters downloadParameters;
        
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

        


        public TwitchDownloadParameters DownloadParameters
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
