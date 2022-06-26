using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string id)
        {
            return "The value of Id = " + id + " and Name = " + Request.QueryString["name"];
        }

        //or

        /*
             public string Index(string id, string name)
             {
                  return "The value of Id = " + id + " and Name = " + name;
             } 
        */


        public string GetDetails()
        {
            return "Get Details Invoked";
        }
    }
}