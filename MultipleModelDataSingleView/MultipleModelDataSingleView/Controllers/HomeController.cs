using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleModelDataSingleView.Models;

namespace MultipleModelDataSingleView.Controllers
{
    public class HomeController : Controller
    {
        SchoolDBEntities db = new SchoolDBEntities();

        public ActionResult Index()
        {
            //var std = getStudents();
            //var tchr = getTeachers();

            //MultiModelData data = new MultiModelData();
            //data.my_students = std;
            //data.my_teachers = tchr;

            //ViewBag.students = std;    
            //ViewData["students"] = std;    
            //ViewBag.teachers = tchr;   
            
            return View();
        }

        public PartialViewResult Students()
        {
            var std = getStudents();
            return PartialView("_students",std);
        }
        public PartialViewResult Teachers()
        {
            var tchr = getTeachers();
            return PartialView("_teachers",tchr);
        }
        public List<student> getStudents()
        {
            return db.students.ToList();
        }
        public List<teacher> getTeachers()
        {
            return db.teachers.ToList();
        }
    }
}