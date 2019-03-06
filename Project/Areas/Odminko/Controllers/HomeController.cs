using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Areas.Odminko.Controllers
{
    public class HomeController : Controller
    {
        // GET: Odminko/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}