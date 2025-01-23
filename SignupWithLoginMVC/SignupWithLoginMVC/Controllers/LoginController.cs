using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SignupWithLoginMVC.Models;

namespace SignupWithLoginMVC.Controllers
{
    public class LoginController : Controller
    {
        SignupLoginEntities1 db = new SignupLoginEntities1();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user u)
        {
            var user = db.users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
            if (user != null)
            {
                Session["UserId"] = u.Id.ToString();
                Session["Username"] = u.username.ToString();
                TempData["LoginSuccessMessage"] = "<script>alert('Login Successfull')</script>";
                return RedirectToAction("Index","User");

            }
            else
            {
                ViewBag.ErrorMessage = "<script>alert('Login Failed')</script>";
                return View();
            }

        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(user u)
        {
            if (ModelState.IsValid == true)
            {
                db.users.Add(u); 
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InsertMessage = "<script>alert('Signup Successfull')</script>";
                    ModelState.Clear(); 
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Signup Failed')</script>";

                }
            }
            return View();
        }
    }
}