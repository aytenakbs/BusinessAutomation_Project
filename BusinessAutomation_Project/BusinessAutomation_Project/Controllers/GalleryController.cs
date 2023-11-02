using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class GalleryController : Controller
    {
        // GET: Gallery
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Products.ToList();
            return View(values);
        }
    }
}