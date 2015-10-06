using Linnworks.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace lnnwrkswbstr.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var repo = new RedisRepository();
            var current = DateTime.Now;
            List<KeyValuePair<string, DateTime>> blakListIps = new List<KeyValuePair<string, DateTime>>() {
                new KeyValuePair<string, DateTime>("10.25.316.10", current.AddSeconds(10)),
                new KeyValuePair<string, DateTime>("10.25.316.15", current.AddSeconds(15)),
                new KeyValuePair<string, DateTime>("10.25.316.20", current.AddSeconds(20)),
                new KeyValuePair<string, DateTime>("10.25.316.25", current.AddSeconds(25)),
                new KeyValuePair<string, DateTime>("10.25.316.30", current.AddSeconds(30)),
                new KeyValuePair<string, DateTime>("10.25.316.35", current.AddSeconds(35)),
                new KeyValuePair<string, DateTime>("10.25.316.40", current.AddSeconds(40)),
                new KeyValuePair<string, DateTime>("10.25.316.45", current.AddSeconds(45)),
                new KeyValuePair<string, DateTime>("10.25.316.50", current.AddSeconds(50))
            };
            //repo.Connect();
            //repo.AddIps(blakListIps);

            //for (int i = 0; i < 20; i++ )
            //{
            //    var keys = repo.GetKeys().ToList();
            //    var k = 1;
            //}

                return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}