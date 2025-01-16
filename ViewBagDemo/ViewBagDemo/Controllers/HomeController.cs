using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Hello !! Message from View Bag !!";
            ViewBag.CurrentDate = DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple", "Banana", "Grapes" };

            ViewBag.FruitsArray = fruits;

            ViewBag.SportsList = new List<string>()
            {
                "Cricket",
                "Football",
                "Ludo",
            };

            Employee e1 = new Employee();
            
            e1.Id = 22;
            e1.Name = "Abc";
            e1.Des = "Manager";

            ViewBag.em = e1;

            ViewBag.CommonMessage = "This msg is accessed by both ViewBag and ViewData";
            

            return View();
        }
    }
}