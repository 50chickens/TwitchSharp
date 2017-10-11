using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchSharp.Implementations
{
    public class CustomContractResolver : DefaultContractResolver
    {
        private Dictionary<string, string> PropertyMappings { get; set; }

        public CustomContractResolver(Dictionary<string, string> propertyMappings)
        {
            this.PropertyMappings = propertyMappings;
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            string resolvedName = null;
            if (this.PropertyMappings.TryGetValue(propertyName, out resolvedName))
            {

                return resolvedName;
            }
            else
            {
                string name = base.ResolvePropertyName(propertyName);
                return name;
            }
             
        }
    }
}
