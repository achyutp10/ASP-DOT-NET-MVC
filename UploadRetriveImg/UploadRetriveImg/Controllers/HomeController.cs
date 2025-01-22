using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadRetriveImg.Models;

namespace UploadRetriveImg.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home

        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(student s)
        {
            string fileName = Path.GetFileNameWithoutExtension(s.ImageFile.FileName);
            string extension = Path.GetExtension(s.ImageFile.FileName);

            HttpPostedFileBase postedFile = s.ImageFile;
            int length = postedFile.ContentLength;

            if (extension.ToLower()==".jpg" || extension.ToLower() == ".png" || extension.ToLower() == ".jpeg")
            {
                if (length <= 1000000)
                {
                    fileName = fileName + extension;
                    s.image_path = "~/images/" + fileName;
                    fileName = Path.Combine(Server.MapPath("~/images/"), fileName);
                    s.ImageFile.SaveAs(fileName);
                    db.students.Add(s);

                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        ViewBag.Message = "<script>alert('Data has been Inserted')</script>";
                        ModelState.Clear();
                    }
                    else
                    {
                        ViewBag.Message = "<script>alert('Data not Inserted')</script>";

                    }
                }
                else
                {
                     ViewBag.SizeMessage = "<script>alert('File should be less than 1mb')</script>";
                }
            }
            else
            {
                        ViewBag.ExtensionMessage = "<script>alert('File not supported')</script>";

            }


            return View();
        }
    }
}