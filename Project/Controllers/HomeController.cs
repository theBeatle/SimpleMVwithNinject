using BusinessLogicLayer;
using DataAccessLayer;
using Project.Models;
using System;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyBll bll; // MyBll bll = new MyBll();

        public HomeController(IMyBll bll)
        {
            //custom test deppendency injection
            //bll = new MyBll(new MyDal(new RAES()));
            this.bll = bll;
        }

        public ActionResult Index()
        {
            var text = bll.EmployessCount();

            var model = new MessageIndexModel
            {
                Message = text,
                EmployeesCount = Int32.Parse(text.Substring(text.IndexOf('=') + 1))
            };

            return View(model);
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