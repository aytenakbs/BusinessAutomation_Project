using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Products.Where(x => x.Status == true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> value1 = (from x in db.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Value = x.CategoryId.ToString(),
                                               Text = x.Name
                                           }).ToList();
            ViewBag.dgr1 = value1;
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product p)
        {
            db.Products.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteProduct(int id)
        {
            var value = db.Products.Find(id);
            value.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}