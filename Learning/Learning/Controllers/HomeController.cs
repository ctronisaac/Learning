using Learning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Learning.Controllers
{
    public class HomeController : Controller
    {


            
        public JsonResult GimmeJSON()
        {
            var person = new Person { FirstName = "Ron", LastName = "Isaac" };

            return Json(person, JsonRequestBehavior.AllowGet);
        }

        public string Ron()
        {
            return "Hi Ron";
        } 


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
    }
}