using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TTO.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
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

        public ActionResult Film()
        {
            ViewBag.Message = "Your game film page.";

            return View();
        }

        public ActionResult Schedule()
        {
            ViewBag.Message = "The Outsider's Schedule.";

            return View();
        }

        public ActionResult Roster()
        {
            ViewBag.Message = "Roster.";

            return View();
        }
    }
}