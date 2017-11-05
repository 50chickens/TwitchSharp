using Twitch.Api;
using Twitch.Api.Vod;
using TwitchSharp.Abstractions;


namespace TwitchSharp.Implementations
{
    public class GetTwitchM3U8TextQuery : ITwitchQuery<string>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchM3U8TextQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        public string NAuthSig { get; set; }

        public string NAuth { get; set; }
        public int VodId { get; set; }

        public string Location
        {
            get
            {
                string url = this.twitchClientOptions.UsherVodUrl.Replace(@"{vodid}", this.VodId.ToString());
                url = url.Replace(@"{nauthsig}", NAuthSig);
                url = url.Replace(@"{nauth}", NAuth);
                return url;

            }


        }

    }
}