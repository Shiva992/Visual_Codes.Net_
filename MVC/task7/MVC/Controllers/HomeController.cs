using MVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult InsertData()
        {

            return View();
        }


        [HttpPost]
        public string InsertData(Class1 r)
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    webClient.Headers.Add("Content-type:application/Json");
                    webClient.Headers.Add("Accept:application/Json");
                    webClient.UploadString("https://localhost:44328/InsertData", JsonConvert.SerializeObject(r));

                }
            }
            catch (Exception)
            {

            }
            return "Registered Successfully";
        }
    }
}