using System;
using System.Collections.Generic;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchDownloadParametersQuery : ITwitchQuery<List<TwitchDownloadParameters>>
    {
        
        private ITwitchQueryOptions twitchClientOptions;
        private string url;
        private List<string> playlist;
        private string folder;
        private string sourceQuality;
        private string destinationquality;

        public GetTwitchDownloadParametersQuery(ITwitchQueryOptions twitchClientOptions)
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

        public string SourceQuality
        {
            get
            {
                return sourceQuality;
            }

            set
            {
                sourceQuality = value;
            }
        }

        public string DestinationQuality
        {
            get
            {
                return destinationquality;
            }

            set
            {
                destinationquality = value;
            }
        }
    }
}