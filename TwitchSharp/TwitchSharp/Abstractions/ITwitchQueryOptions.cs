namespace TwitchSharp.Abstractions
{
    public interface ITwitchQueryOptions
    {
        string KrakenChannelInfoUrl { get; set; }
        string KrakenChannelVideosUrl { get; set; }
        string KrakenFeaturedStreamsUrl { get; set; }
        string KrakenGameVideosUrl { get; set; }
        string KrakenLiveGamesUrl { get; set; }
        string KrakenLiveStreamsUrl { get; set; }
        string KrakenSearchChannelsUrl { get; set; }
        string KrakenSearchGamesUrl { get; set; }
        string KrakenSearchStreamsUrl { get; set; }
        string KrakenTopGamesUrl { get; set; }
        string KrakenTopVideosUrl { get; set; }
        string KrakenVodInfoUrl { get; set; }
        string TwitchApplicationAuthorizationReturnURL { get; set; }
        string TwitchApplicationAuthorizationReturnURLEncoded { get; set; }
        string TwitchApplicationAuthorizationUrl { get; set; }
        string TwitchChannelInfoUrl { get; set; }
        string TwitchDownloaderURL { get; set; }
        string TwitchOAuthTokenUrl { get; set; }
        string UsherTokenUrl { get; set; }
        string UsherVodUrl { get; set; }
    }
}