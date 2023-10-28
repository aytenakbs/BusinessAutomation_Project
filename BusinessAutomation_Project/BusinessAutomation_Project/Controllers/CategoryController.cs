using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Categories.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteCategory(int id)
        {
            var value = db.Categories.Find(id);
            db.Categories.Remove(value);
            db.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult GetCategory(int id)
        {
            var value = db.Categories.Find(id);

            return View(value);
        }

        public ActionResult UpdateCategory(Category ctg)
        {
            var value = db.Categories.Find(ctg.CategoryId);
            value.Name=ctg.Name;
            db.SaveChanges();
            return RedirectToAction("index");
        }
    }
}