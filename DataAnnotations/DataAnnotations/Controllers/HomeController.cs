using DataAnnotations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace DataAnnotations.Controllers
{
    public class HomeController : Controller
    {
        string EmailPattern = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$";

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Employee e)
        {

            if (e.Name.Equals("") == true)
            {
                ModelState.AddModelError("Name", "Name is Required");
                ViewData["fullNameError"] = "*";
            }
            if (e.Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is Required");
                ViewData["AgeError"] = "*";
            }
            if (e.Gender.Equals("") == true)
            {
                ModelState.AddModelError("Gender", "Gender is Required");
                ViewData["AgeError"] = "*";
            }
            if (e.Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is Required");
                ViewData["EmailError"] = "*";
            }
            else
            {
                if (Regex.IsMatch(e.Email, EmailPattern) == false)
                {
                    ModelState.AddModelError("Email", "Invalid Email");
                    ViewData["EmailError"] = "*";
                }
            }

            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has been submitted')</script>";
                ModelState.Clear();
            }
            
            return View();
        }
    }
}