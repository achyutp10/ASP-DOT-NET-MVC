using Difference_ViewBag_ViewData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Difference_ViewBag_ViewData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["Message1"] = "Data comes from ViewData";
            ViewBag.Message2 = "Data comes from ViewBag";

            ViewData["CurrDate1"] = DateTime.Now.ToString();
            ViewBag.CurrDate2 = DateTime.Now.ToString();

            string[] games = { "Hockey", "Football" };
            ViewData["GamesArray1"] = games;
            ViewBag.GamesArray2 = games;

            Employee achyut = new Employee();

            achyut.Id = 1;
            achyut.Name = "Achyut";
            achyut.Desc = "Juior";

            ViewData["Em1"] = achyut;
            ViewBag.Em2 = achyut;



            return View();
        }

        public ActionResult About()
        {

            return View();
        }
    }
}