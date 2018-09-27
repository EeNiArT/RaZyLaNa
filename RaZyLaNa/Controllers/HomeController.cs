using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaZyLaNa.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Rezyla()
        {
            ViewBag.Message = "Your news feed.";

            return View();
        }

        public ActionResult TermsOfService()
        {
            ViewBag.Message = "Terms Of Service";

            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            ViewBag.Message = "Privacy Policy";

            return View();
        }
    }
}