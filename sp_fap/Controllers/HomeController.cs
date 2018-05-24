using sp_fap.Content;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sp_fap.Controllers
{
    public class HomeController : Controller
    {
        private Db_ContextProg db = new Db_ContextProg(ConfigurationManager.ConnectionStrings[0].ConnectionString);
        public ActionResult Index()
        {
            ViewBag.inf = db.Users_m.ToList();
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
        public ActionResult Main1()
        {

            return View();
        }
    }
}