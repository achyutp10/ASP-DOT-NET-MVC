using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirst.Models;
using System.Data.Entity;

namespace EFCodeFirst.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
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
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted')</script>";
                    //TempData["InsertMessage"] = "<script>alert('Data Inserted')</script>";
                    TempData["InsertMessage"] = "Data Inserted";

                    //ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data not Inserted')</script>";
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();
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
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted')</script>";
                    //TempData["InsertMessage"] = "<script>alert('Data Inserted')</script>";
                    TempData["InsertMessage"] = "Data Updated";

                    //ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data not Updated')</script>";
                }
            }

            return View();
        }

        
        public ActionResult Delete(int id)
        {
            if (id > 0)
            {
            var row = db.Students.Where(model => model.Id == id).FirstOrDefault();
                if (row != null)
                {
                    db.Entry(row).State = EntityState.Deleted;
                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["InsertMessage"] = "Data Deleted";                       
                    }
                    else
                    {
                        TempData["InsertMessage"] = "Data Not Deleted";

                    }

                }
            }
            
            return RedirectToAction("Index");
        }

        

    }

}