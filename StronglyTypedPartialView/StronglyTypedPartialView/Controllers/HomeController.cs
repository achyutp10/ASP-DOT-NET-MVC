using StronglyTypedPartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StronglyTypedPartialView.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        List<Product> ProductsList = new List<Product>()
        {
            new Product {id=1,name="Rebook Shoes",price=10000.00,picture="~/images/a.png"},
            new Product {id=2,name="Reyben Sunglasses",price=1000.00,picture="~/images/a_lTfdtEb.png"},
            new Product {id=3,name="Watch",price=5000.00,picture="~/images/HarryPotter.png"}
        };
        public ActionResult Index()
        {
            return View(ProductsList);
        }
    }
}