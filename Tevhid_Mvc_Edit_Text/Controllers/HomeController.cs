using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_edit_text.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Anasayfa";

            return View();
        }

        public ActionResult Article()
        {
            ViewBag.Title = "Metinlerin olduğu sayfa";

            return View();
        }

        public ActionResult Vocable()
        {
            ViewBag.Title = "Kelimelerin olduğu sayfa";

            return View();
        }
    }
}
