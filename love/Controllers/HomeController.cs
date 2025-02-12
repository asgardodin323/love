using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace love.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DateTime startDate = new DateTime(2022, 09, 14, 00, 00, 00); // İlk gününüzü buraya gir
            ViewBag.StartDate = startDate.ToString("yyyy-MM-ddTHH:mm:ss"); // JS için formatlıyoruz

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