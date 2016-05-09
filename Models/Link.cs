using Newtonsoft.Json;

namespace org.cdshooks.example.Models
{
    public class Link
    {
        public Link(string label, string url = "")
        {
            Label = label;
            Url = url;
        }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string Label { get; internal set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; internal set; }
    }
}
