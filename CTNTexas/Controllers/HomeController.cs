using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CTNTexas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ClinicalStudies()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Facility()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Awards()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CommunityService()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AboutUs()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ContactUs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}