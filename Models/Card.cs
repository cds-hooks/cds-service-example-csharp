using System.Collections.Generic;
using Newtonsoft.Json;

namespace org.cdshooks.example.Models
{
    public class Card
    {
        public Card(string summary, Indicator indicator, Link source)
        {
            Summary = summary;
            Indicator = indicator;
            Detail = "";
            Source = source;
            Links = new List<Link>();
        }

        [JsonProperty("summary", NullValueHandling = NullValueHandling.Ignore)]
        public string Summary { get; internal set; }

        [JsonProperty("indicator", NullValueHandling = NullValueHandling.Ignore)]
        public Indicator Indicator { get; internal set; }

        [JsonProperty("detail", NullValueHandling = NullValueHandling.Ignore)]
        public string Detail { get; internal set; }

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public Link Source { get; internal set; }

        [JsonProperty("links", NullValueHandling = NullValueHandling.Ignore)]
        public IList<Link> Links { get; internal set; }

    }
}
