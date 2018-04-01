﻿using System;
using System.Collections.Generic;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchDownloadQuery : ITwitchQuery<List<TwitchDownload>>
    {
        
        private ITwitchQueryOptions twitchClientOptions;
        private string url;
        private List<string> playlist;
        private string folder;
        private string quality;
        
        

        public GetTwitchDownloadQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        
        public List<string> Playlist
        {
            get
            {
                return playlist;
            }

            set
            {
                playlist = value;
            }
        }

        

        

        public string Location
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Url
        {
            get
            {
                return url;
            }

            set
            {
                url = value;
            }
        }

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

        
        public string Quality
        {
            get
            {
                return quality;
            }

            set
            {
                quality = value;
            }
        }

        
    }
}