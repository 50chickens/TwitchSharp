using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twitch.Api.Usher
{
    public class UsherTokenReply
    {
        public string token { get; set; }
        public string sig { get; set; }
    }
    public class UsherToken
    {
        public int? user_id { get; set; }

        public int? vod_id { get; set; }
        public int? expires { get; set; }
        public Chansub chansub { get; set; }
        public bool privileged { get; set; }

    }
    public class Chansub
    {
        public List<object> restricted_bitrates { get; set; }
    }
}
