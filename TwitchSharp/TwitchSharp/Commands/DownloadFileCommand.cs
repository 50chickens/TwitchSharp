﻿using TwitchSharp.Implementations;

namespace TwitchSharp
{

    public class DownloadFileCommand
    {
        public string Filename { get; set; }

        public string Folder { get; set; }

        public string Url { get; set; }

        public bool CreateSubfolder { get; set; }

        public string SubFolderName { get; set; }

    }

}