using System.Collections.Generic;
using Newtonsoft.Json;

namespace org.cdshooks.example.Models
{
    public class Service
    {
        public Service(string id, string hook, string name)
        {
            ID = id;
            Hook = hook;
            Name = name;
            Prefetch = new Dictionary<string, string>();
        }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string ID { get; internal set; }

        [JsonProperty("hook", NullValueHandling = NullValueHandling.Ignore)]
        public string Hook { get; internal set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; internal set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; internal set; }

        [JsonProperty("prefetch", NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string> Prefetch { get; internal set; }
    }
}
