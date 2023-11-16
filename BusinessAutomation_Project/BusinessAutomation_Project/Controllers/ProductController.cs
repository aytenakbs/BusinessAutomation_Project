using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        Context db = new Context();
        public ActionResult Index(string p)
        {
            var values = from x in db.Products select x;
            if (!string.IsNullOrEmpty(p))
            {
                values = values.Where(x => x.Name.Contains(p));
            }
            return View(values.ToList());
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            List<SelectListItem> value1 = (from x in db.Categories.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.CategoryId.ToString()
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

        public ActionResult GetProduct(int id)
        {
            List<SelectListItem> value1 = (from x in db.Categories.ToList()
                select new SelectListItem
                {
                    Text = x.Name,
                    Value = x.CategoryId.ToString()
                }).ToList();
            ViewBag.dgr1 = value1;
            var value = db.Products.Find(id);
            return View(value);
        }

        public ActionResult UpdateProduct(Product p)
        {
            var value = db.Products.Find(p.ProductId);
            
            value.CategoryId = p.CategoryId;
            value.Brand=p.Brand;
            value.Name=p.Name;
            value.Image=p.Image;
            value.PurchasePrice=p.PurchasePrice;
            value.SalesPrice=p.SalesPrice;
            value.Stock=p.Stock;
            value.Status = p.Status;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult ProductList()
        {
            var values = db.Products.ToList();
            return View(values);
        }
    }
}