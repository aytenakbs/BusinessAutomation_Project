using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;
using PagedList;
using PagedList.Mvc;

namespace BusinessAutomation_Project.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        Context db = new Context();
        public ActionResult Index(int page=1)
        {
            var values = db.Categories.ToList().ToPagedList(page,4);
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