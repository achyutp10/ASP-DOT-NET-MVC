using StronglyTypedView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Id = 1;
            emp1.Name = "Test";
            emp1.Age = 30;

            Employee emp2 = new Employee();
            emp2.Id = 2;
            emp2.Name = "Test2";
            emp2.Age = 31;

            Employee emp3 = new Employee();
            emp3.Id = 3;
            emp3.Name = "Test3";
            emp3.Age = 33;

            ViewData["Var1"] = emp1;
            ViewBag.Var2 = emp1;

            List<Employee> empList = new List<Employee>();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);

            return View(empList);
        }
    }
}