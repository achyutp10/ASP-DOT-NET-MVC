using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
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
                    //return Json("Data Inserted !!"); 
                    return JavaScript("alert('Data Inserted !!')"); 
                }
                else
                {
                    //return Json("Data Not Inserted !!");
                    return JavaScript("alert('Data not Inserted !!')");

                }
            }
            return View();
        }

        public ActionResult Index()
        {

            return View(db.employees.ToList());
        }

        [HttpPost]
        public ActionResult Index(string q)
        {
            if (string.IsNullOrEmpty(q) == false)
            {
                List<employee> emp = db.employees.Where(model => model.name.StartsWith(q)).ToList();
                return PartialView("_SearchData",emp);
            }
            else
            {
                List<employee> emp = db.employees.ToList();
                return PartialView("_SearchData", emp);
            }
        }

        public ActionResult Index2()
        {

            return View();
        }
        public ActionResult AllEmployees()
        {
            var data = db.employees.ToList();
            return PartialView("_Employees",data);
        }

        public ActionResult Top3Emp()
        {
            var data = db.employees.OrderByDescending(model => model.salary).Take(3).ToList();
            return PartialView("_Employees",data);
        }
        public ActionResult Bottom3Emp()
        {
            var data = db.employees.OrderBy(model => model.salary).Take(3).ToList();
            return PartialView("_Employees",data);
        }


        public ActionResult Index3()
        {
            int num = 2;
            Session["data"] = num;
            var data = db.employees.ToList().Take(num);
            return View(data);
        }

        [HttpPost]
        public ActionResult Index3(employee e)
        {
            int rows = Convert.ToInt32(Session["data"]) + 2;
            var data = db.employees.ToList().Take(rows);
            Session["data"] = rows;
            return PartialView("_EmpData",data);
        }
    }
}