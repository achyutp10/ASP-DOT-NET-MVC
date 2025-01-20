using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDatabaseFirst.Models;
using System.Data.Entity;

namespace EFDatabaseFirst.Controllers
{
    public class HomeController : Controller
    {
        DatabaseFirstEntities db = new DatabaseFirstEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["Message"] = "Data Inserted";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "Data Not Inserted";
                }
            }
            
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["Message"] = "Data Updated";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "Data Not Updated";
                }
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
                var deletedRow = db.Students.Where(model => model.id == id).FirstOrDefault();
                if (deletedRow != null)
                {
                    db.Entry(deletedRow).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["Message"] = "Data Deleted";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        TempData["Message"] = "Data Not Deleted";
                    }
                }
            }

            return View();
        }

        //[HttpPost]
        //public ActionResult Delete(Student s)
        //{
        //    db.Entry(s).State = EntityState.Deleted;
        //    int a = db.SaveChanges();
        //    if (a > 0)
        //    {
        //        TempData["Message"] = "Data Deleted";
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        TempData["Message"] = "Data Not Deleted";
        //    }
        //    return View();
        //}

        public ActionResult Details(int id)
        {
            var row = db.Students.Where(model => model.id == id).FirstOrDefault();
            return View(row);
        }

    }
}