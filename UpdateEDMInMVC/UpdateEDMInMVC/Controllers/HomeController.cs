using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UpdateEDMInMVC.Models;

namespace UpdateEDMInMVC.Controllers
{
    public class HomeController : Controller
    {
        EDMExampleMVCEntities db = new EDMExampleMVCEntities();

        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }
        public ActionResult Employee()
        {
            var data = db.empolyees.ToList();
            return View(data);
        }
    }
}