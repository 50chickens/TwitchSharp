using Twitch.Api.Usher;
using TwitchSharp.Abstractions;

namespace TwitchSharp.Implementations
{
    public class GetTwitchAuthTokenQuery : ITwitchQuery<UsherTokenReply>
    {
        private ITwitchQueryOptions twitchClientOptions;

        public GetTwitchAuthTokenQuery(ITwitchQueryOptions twitchClientOptions)
        {
            this.twitchClientOptions = twitchClientOptions;

        }
        
        //public string VodUrl { get; set; }
        public int VodId { get; set; }

        public string Location
        {
            get
            {
                //https://api.twitch.tv/api/vods/156832421/access_token?as3=t 
                return this.twitchClientOptions.UsherTokenUrl.Replace(@"{vodid}", this.VodId.ToString());

            }


        }

    }
}