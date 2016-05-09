using System.Collections.Generic;

namespace org.cdshooks.example.Models
{
    public static class ServiceRepository
    {
        public static IList<Service> Get()
        {
            return new List<Service>
            {
                StaticService
            };
        }

        private static Service StaticService
        {
            get
            {
                var service = new Service("static", "patient-view", "Static CDS Service in CSharp")
                {
                    Description = "An example static CDS service in CSharp"
                };

                service.Prefetch.Add("patient", "Patient/{{Patient.id}}");
                return service;
            }
        }
    }

    public static class CardRepository
    {
        public static IList<Card> Get()
        {
            var card1 = Create("Success Card", Indicator.Success, new Link("Static CDS Service", "http://example.com"));
            card1.Detail = "This is a test of a static success card.";
            card1.Links.Add(new Link("Google", "https://google.com"));
            card1.Links.Add(new Link("Github", "https://github.com"));

            var source = new Link("Static CDS Service");

            var card2 = Create("Info card", Indicator.Info, source);
            var card3 = Create("Warning card", Indicator.Warning, source);
            var card4 = Create("Hard stop card", Indicator.HardStop, source);

            return new List<Card>
            {
                card1, card2, card3, card4
            };
        }

        private static Card Create(string summary, Indicator indicator, Link source)
        {
            return new Card(summary, indicator, source);
        }
    }
}
