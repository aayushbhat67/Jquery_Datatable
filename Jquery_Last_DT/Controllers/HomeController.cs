using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jquery_Last_DT.Models;


namespace Jquery_Last_DT.Controllers
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

        public JsonResult ClientDetail()
        {
            JQLastEntities1 db = new JQLastEntities1();
            db.Configuration.ProxyCreationEnabled = false;
            List<Customer> Customer = db.Customers.ToList();
            return Json(new { data = Customer }, JsonRequestBehavior.AllowGet);
        }
    }
}