using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;

namespace Twitch.Api.Vod
{
    internal class VodInfoConverter : JsonConverter
    {
        public const string QUALITY_SOURCE = "chunked";
        public const string QUALITY_HIGH = "high";
        public const string QUALITY_MEDIUM = "medium";
        public const string QUALITY_LOW = "low";
        public const string QUALITY_MOBILE = "mobile";
        public const string QUALITY_AUDIO = "audio_only";
        public override bool CanConvert(Type objectType)
        {
            
            return objectType == typeof(Vod);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jsonObject = JObject.Load(reader);

            JObject fpsJson = jsonObject.Value<JObject>("fps");
            JObject resolutionJson = jsonObject.Value<JObject>("resolutions");


            
            foreach (JProperty fps in fpsJson.Values<JProperty>())
            {
                fps.Value = ((int)Math.Round(fps.Value.Value<double>(), 0)).ToString();

                JProperty resolution = resolutionJson.Values<JProperty>().Where(x => x.Name == fps.Name).FirstOrDefault();

                if (resolution != null)
                {
                    //JProperty resolution in resolutionJson.Values<JProperty>().Where(resolution => resolution.Name == fps.Name)
                    switch (resolution.Name)
                    {
                        case "160p30":
                            {
                                //resolution.Name = QUALITY_MOBILE;
                                break;

                            }
                        case "360p30":
                            {
                                break;

                            }
                        case "480p30":
                            {
                                break;

                            }
                        case "720p30":
                            {
                                break;

                            }
                            

                         default:
                            
                                break;

                            
                    }
                }
                
            }
            //}

            

            return null;

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}