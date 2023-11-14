using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebControll.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Описание вашего приложения.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ваши контакты.";

            return View();
        }
    }
}