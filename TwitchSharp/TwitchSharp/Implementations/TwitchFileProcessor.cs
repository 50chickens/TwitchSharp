using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchSharp.Abstractions;
using TwitchSharp.Api;

namespace TwitchSharp.Implementations
{
    public class TwitchFileProcessor : ITwitchFileProcessor
    {
        public List<TwitchVideoQuality> GetVodQualities(string vodInfoResponse)
        {
            JObject videosResponseJson = JObject.Parse(vodInfoResponse);

            List<TwitchVideoQuality> qualities = ParseQualities(videosResponseJson.Value<JObject>("resolutions"), videosResponseJson.Value<JObject>("fps"));

            return qualities;
        }

        public List<TwitchVideoQuality> ParseQualities(JObject resolutionsJson, JObject fpsJson)
        {
            List<TwitchVideoQuality> qualities = new List<TwitchVideoQuality>();

            Dictionary<string, string> fpsList = new Dictionary<string, string>();

            if (fpsJson != null)
            {
                foreach (JProperty fps in fpsJson.Values<JProperty>())
                {
                    fpsList.Add(fps.Name, ((int)Math.Round(fps.Value.Value<double>(), 0)).ToString());
                }
            }

            if (resolutionsJson != null)
            {
                foreach (JProperty resolution in resolutionsJson.Values<JProperty>())
                {
                    string value = resolution.Value.Value<string>();
                    string qualityId = resolution.Name;
                    string fps = fpsList.ContainsKey(qualityId) ? fpsList[qualityId] : null;

                    qualities.Add(new TwitchVideoQuality(qualityId, value, fps));
                }
            }

            if (fpsList.ContainsKey(TwitchVideoQuality.QUALITY_AUDIO))
            {
                qualities.Add(new TwitchVideoQuality(TwitchVideoQuality.QUALITY_AUDIO));
            }

            if (!qualities.Any())
            {
                qualities.Add(new TwitchVideoQuality(TwitchVideoQuality.QUALITY_SOURCE));
            }

            qualities.Sort();

            return qualities;
        }

    }
}
