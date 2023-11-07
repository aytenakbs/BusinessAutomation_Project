using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class ProductDetailController : Controller
    {
        // GET: ProductDetail
        Context db = new Context();
        public ActionResult Index()
        {
            ProductDetail pd = new ProductDetail();
            //var values = db.Products.ToList();
            pd.Value1 = db.Products.Where(x => x.ProductId == 1).ToList();
            pd.Value2 = db.Details.Where(x => x.DetailId == 1).ToList();
            return View(pd);
        }
    }
}