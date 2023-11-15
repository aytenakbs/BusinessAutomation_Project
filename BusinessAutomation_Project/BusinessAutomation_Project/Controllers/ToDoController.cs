using BusinessAutomation_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessAutomation_Project.Controllers
{
    public class ToDoController : Controller
    {
        // GET: ToDo
        Context db = new Context();
        public ActionResult Index()
        {
            var value1=db.Customers.Count().ToString();
            var value2 = db.Products.Count().ToString();
            var value3 = db.Categories.Count().ToString();
            ViewBag.d1=value1; ViewBag.d2=value2; ViewBag.d3=value3;
            var value4 = (from x in db.Customers select x.City).Distinct().Count().ToString();
            ViewBag.d4 = value4;
            var values=db.ToDos.ToList();
            return View(values);
        }
    }
}