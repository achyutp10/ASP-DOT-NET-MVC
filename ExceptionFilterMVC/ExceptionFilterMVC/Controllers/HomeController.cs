using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExceptionFilterMVC.Controllers
{
    //[HandleError]
    [HandleError(View = "Error")]
    public class HomeController : Controller
    {
        // GET: Home
        //public ActionResult Index()
        //{
        //    try
        //    {
        //        throw new Exception();
        //    }
        //    catch (Exception ex)
        //    {
        //        return RedirectToAction("ErrorPage", "Home");           
        //    }


        //    return View();
        //}

        //public ActionResult ErrorPage()
        //{

        //    return View();
        //}

        //[HandleError(View = "Error")]
        //[HandleError]
        public ActionResult Index()
        {
            throw new Exception();
            return View();
        }

        //[HandleError(View = "Error2")]
        //[HandleError]
        public ActionResult About()
        {
            throw new Exception();
            return View();
        }
        }
}