using BusinessAutomation_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessAutomation_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context db=new Context();
        public ActionResult Index()
        {

            return View();
        }
        [HttpGet]
        public PartialViewResult Partial1()
        {

            return PartialView();
        }
        [HttpPost]
        public PartialViewResult Partial1(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}