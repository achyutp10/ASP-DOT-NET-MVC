using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OutputCacheFilter.Models;

namespace OutputCacheFilter.Controllers
{
    
    public class HomeController : Controller
    {
        PersonEntities db = new PersonEntities();
        // GET: Home
        //[OutputCache(Duration = 10, Location = System.Web.UI.OutputCacheLocation.Server)]
        //[OutputCache(Duration = 10, Location = System.Web.UI.OutputCacheLocation.Any)]
        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            ViewBag.Time = DateTime.Now.ToLongTimeString();
            return View();
        }

        [OutputCache(Duration = 40)]
        public ActionResult GetData()
        {

            var data = db.people.ToList();
            return View(data);
        }
    }
}