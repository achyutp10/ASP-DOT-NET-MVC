using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using RemMeMvcCheckBox.Models;

namespace RemMeMvcCheckBox.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities1 db = new LoginDBEntities1();
        // GET: Login
        public ActionResult Index()
        {
            HttpCookie cookie = Request.Cookies["User"];
            if (cookie != null)
            {
                ViewBag.username = cookie["username"].ToString();

                string EncryptPassword = cookie["password"].ToString();
                byte[] b = Convert.FromBase64String(EncryptPassword);
                string decryptPassword = ASCIIEncoding.ASCII.GetString(b);

                ViewBag.password = decryptPassword.ToString();
            }
            return View();
        }

        [HttpPost]
        public ActionResult Index(User u)
        {
            HttpCookie cookie = new HttpCookie("User");

            if (ModelState.IsValid == true)
            {
                if (u.RememberMe == true)
                {
                    cookie["username"] = u.username;
                    byte[] b = ASCIIEncoding.ASCII.GetBytes(u.password);
                    string EncryptedPassword = Convert.ToBase64String(b);
                    cookie["password"] = EncryptedPassword;
                    cookie.Expires = DateTime.Now.AddDays(2);
                    HttpContext.Response.Cookies.Add(cookie);
                }
                else
                {
                    cookie.Expires = DateTime.Now.AddDays(-1);
                    HttpContext.Response.Cookies.Add(cookie);
                }
                var row = db.Users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
                if (row != null)
                {
                    Session["Username"] = u.username;
                    TempData["Message"] = "<script>alert('Login Successful')</ script>";
                    return RedirectToAction("Index", "Dashboard");
                }
                else
                {
                    TempData["Message"] = "<script>alert('Login Failed')</ script>";
                }
            }
            return View();
        }
    }
}