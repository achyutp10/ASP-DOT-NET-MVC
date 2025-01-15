using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message"] = "Message from View Data";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] Fruits = { "Apple", "Banana", "Grapes", "Orange"};
            ViewData["FruitsData"] = Fruits;

            ViewData["SportsList"] = new List<string>()
            {
                "Cricket",
                "Football",
                "Hockey",
                "Volley Ball",
            };

            Enployee Ali = new Enployee();
            Ali.EmpID = 11;
            Ali.EmpName = "Ali Khan";
            Ali.EmpDesignation = "Manager";

            ViewData["Enployee"] = Ali;


            return View();
        }
    }
}