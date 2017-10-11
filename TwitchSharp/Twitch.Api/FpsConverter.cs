using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using System.Linq;

namespace Twitch.Api.Vod
{
    internal class FpsConverter : JsonConverter


    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {

            //double o = 0;

            //if (double.TryParse(reader.Value.ToString(), out o))
            //{

            //    return (int)Math.Round(o, 0);

            //}

            //else
            //{
            //    return (int)o;
            //}


            JObject jsonObject = JObject.Load(reader);

            Fps fps = new Fps();
            var properties = jsonObject.Properties().ToList();
            //foreach (JProperty jproperty in jsonObject.Properties())
            //{


            //}
            //double o;

            //foreach (JProperty jproperty in jsonObject.Values<JProperty>())
            //{
            //    int t = ((int)Math.Round(jproperty.Value.Value<double>(), 0));
            //    //fpsList.Add(fps.Name, );
            //    fps.GetType().GetProperty(jproperty.Name, BindingFlags.Public | BindingFlags.Instance).SetValue(fps, t);

            //}

            //return fps;

            double n = 0;

            return n;

            //this.GetType().GetProperty(item[0]).SetValue(this, item[1]);

            //if (double.TryParse(reader.Value.ToString(), out o))
            //{
            //    return (int)Math.Round(o, 0);
            //}


            //else
            //{
            //    return 0;
            //}

            //return reader.Value;

            //return jsonObject;
            //foreach (JProperty fps in fpsJson.Values<JProperty>())
            //{
            //    fpsList.Add(fps.Name, ((int)Math.Round(fps.Value.Value<double>(), 0)).ToString());
            //}
            //JObject jsonObject = JObject.Load(reader);

            //fps.Value = ((int)Math.Round(existingValue.Value<double>(), 0)).ToString();

            //JObject fpsJson = jsonObject.Value<JObject>("fps");
            //JObject resolutionJson = jsonObject.Value<JObject>("resolutions");
            //return existingValue;

            // return existingValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            //return serializer.Deserialize(reader, objectType);

            serializer.Serialize(writer, value);

        }
    }
}