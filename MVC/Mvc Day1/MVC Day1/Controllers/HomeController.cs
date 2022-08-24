using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TempData["Message"] = "Hello";
            return View();
        }
        [HttpPost]
        public ActionResult Submit()
        {
            var message = TempData["Message"];

            return View();
        }

            public ActionResult Someview()
        {
            if (DateTime.Now.Day%2==0)
            {
                return View("View1");

            }
            else
            {
                return Json("Data");
            }
        }

        //        public ActionResult Contact()
        //        {
        //            ViewBag.Message = "Your contact page.";

            //            return View();
            //        }
            //    }
            //}
        }
}