using System;
using System.Collections.Generic;
using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchTSPlaylistQuery : ITwitchQuery<List<string>>
    {
        private ITwitchQueryOptions twitchClientOptions;
        private string m3utext;

        public GetTwitchTSPlaylistQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }

        public string M3UText
        {
            get
            {
                return m3utext;
            }
            set
            {
                this.m3utext = value;
            }
        }

        public string Location
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}