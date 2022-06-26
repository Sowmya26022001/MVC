using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class Home1Controller : Controller
    {
        public ActionResult Index()
        {         
            ViewBag.Countries = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"
            };

            return View();
        }
    }
}