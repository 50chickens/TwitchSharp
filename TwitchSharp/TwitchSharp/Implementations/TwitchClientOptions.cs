using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class TwitchClientOptions : ITwitchClientOptions
    {
        public string TwitchApplicationAuthorizationReturnURL { get; set; }
        public string TwitchApplicationAuthorizationReturnURLEncoded { get; set; }
        public string TwitchDownloaderURL { get; set; }

        public string TwitchApplicationAuthorizationUrl { get; set; }
        public string TwitchOAuthTokenUrl { get; set; }

        public string UsherTokenUrl { get; set; }
        public string UsherVodUrl { get; set; }

        public string TwitchChannelInfoUrl { get; set; }
        public string KrakenVodInfoUrl { get; set; }
        public string KrakenChannelInfoUrl { get; set; }
        public string KrakenChannelVideosUrl { get; set; }
        public string KrakenLiveStreamsUrl { get; set; }
        public string KrakenTopVideosUrl { get; set; }
        public string KrakenTopGamesUrl { get; set; }

        public string KrakenLiveGamesUrl { get; set; }
        public string KrakenGameVideosUrl { get; set; }
        public string KrakenFeaturedStreamsUrl { get; set; }

        public string KrakenSearchStreamsUrl { get; set; }
        public string KrakenSearchGamesUrl { get; set; }
        public string KrakenSearchChannelsUrl { get; set; }

        public string scope = "user_read";
        public string BaseUrl = "";
        public string Action = "";


        public string GetLocation(string key)
        {
            throw new NotImplementedException();
        }
    }
}
