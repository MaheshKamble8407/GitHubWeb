using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubWeb.Controllers 
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Name = "Mahesh Added Line";
            ViewBag.FullName = "Swapnil Jadhav Added Line";

            ViewBag.Gender = "Male";

            ViewBag.SecLine = "Mahesh added 2nd line ";

            ViewBag.thrdLine = "Rohit added Line";

            ViewBag.Mahesh = "Mahesh added 3rd Line";
            ViewBag.Swapnil = "Mahesh added 4rd Line";

            ViewBag.frthline = "Rohit 2nd line";
            ViewBag.fithline = "Rohit 3nd line";


            ViewBag.MaheshNew = "Mahesh Added New Extra";

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