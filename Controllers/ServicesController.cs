using System.Collections.Generic;
using Microsoft.AspNet.Cors;
using Microsoft.AspNet.Mvc;
using org.cdshooks.example.Models;

namespace org.cdshooks.example.Controllers
{
    [EnableCors("WithCredentialsAnyOrigin")]
    public class ServicesController : Controller
    {

        [HttpGet("/cds-services")]
        public ActionResult Discovery()
        {
            var services = new Dictionary<string, IList<Service>>
            {
                { "services", ServiceRepository.Get() }
           };

            return Json(services);
        }

        [HttpPost("/cds-services/static")]
        public ActionResult Static([FromBody]string value)
        {
            var cards = new Dictionary<string, IList<Card>>
            {
                { "cards", CardRepository.Get() }
            };

            return Json(cards);
        }
    }
}
