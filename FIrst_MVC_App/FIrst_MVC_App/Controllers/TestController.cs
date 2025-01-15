using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIrst_MVC_App.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            int a = 1; 
            int b = 2;
            ViewBag.A = a;
            ViewBag.B = b;
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}