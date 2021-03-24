using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LanchoNetEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            
            ViewBag.Message = "Site mais gostoso da Net.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ligue pra gnt e seja feliz";

            return View();
        }
    }
}