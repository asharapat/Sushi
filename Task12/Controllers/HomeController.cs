using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task12.Models;

namespace Task12.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext dbs = new ApplicationDbContext();
        public ActionResult Index()
        {
            var items = dbs.Towars.ToList();
            return View(items);
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Create(string name, string price, string description, string url)
        {
            Tovar tovar = new Tovar();
            tovar.name = name;
            tovar.price = price;
            tovar.description = description;
            tovar.url = url;
            return RedirectToAction("Index");

        }*/

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}