using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxBeginFormMVC.Models;

namespace AjaxBeginFormMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        EmployeeDBEntities1 db = new EmployeeDBEntities1();
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(employee e)
        {
            if (ModelState.IsValid == true)
            {
                db.employees.Add(e);
                int a = db.SaveChanges();
                if (a > 0) 
                {
                    return Json("Data Inserted !!"); 
                }
                else
                {
                    return Json("Data Not Inserted !!");
                }
            }
            return View();
        }


    }
}