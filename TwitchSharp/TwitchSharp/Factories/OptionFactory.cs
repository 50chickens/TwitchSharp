using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Implementations
{
    public class OptionFactory
    {
        public static T Create<T>(string json)
        {
            T t = JsonConvert.DeserializeObject<T>(json);
            return JsonConvert.DeserializeObject<T>(json);

        }


        
    }
}
