using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace viewdata_viewbag.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //viewdata
        public ActionResult Index()
        {
            ViewData["name"] = "soumya";
            ViewData["check"] = 1;
            ViewData["As"] = 54343;
            ViewData["lastname"] = "lastname enter";
            return View();
        }
        //viewbag

        public ActionResult About()
        {
            ViewBag["name"] = "soumya";
            ViewBag["check"] = 1;
            ViewBag["As"] = 54343;
            ViewBag["lastname"] = "lastname enter";
            return View();
        }

        //temp data
        public ActionResult Index1()//Action
        {
            ViewData["name"] = "soumya";
            
            return RedirectToAction("code");
        }
        public ActionResult code()
        {
           
            ViewBag.data = TempData["name"].ToString();
            return View();


        }
    }
}