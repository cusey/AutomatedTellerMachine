using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AutomatedTellerMachine.Controllers
{
    public class HomeController : Controller
    {
        //GET /Home/Index
        public ActionResult Index()
        {
            return View();
        }


        //GET /Home/About
        public ActionResult About()
        {
            ViewBag.Message = "The Countries which Summer Time Bank operates in.";

            ViewBag.Countries = new List<String>()
            {
                "India",
                "United States",
                "Canada",
                "Kenya"

            };

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "STB 18.01.30.05";

            if( letterCase == "lower")
            {
                return Content(serial.ToLower());
            }

            return Content(serial);
        }
    }
}