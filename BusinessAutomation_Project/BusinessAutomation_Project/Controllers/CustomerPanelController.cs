using BusinessAutomation_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BusinessAutomation_Project.Controllers
{
    public class CustomerPanelController : Controller
    {
        // GET: CustomerPanel
        Context db=new Context();
        [Authorize]
        public ActionResult Index()
        {
            var email = (string)Session["Mail"];
            var values = db.Customers.FirstOrDefault(x => x.Mail == email);
            ViewBag.m = email;
            return View(values);
        }
        public ActionResult Index2()
        {
            return View();
        }
        public ActionResult Order()
        {
            var email = (string)Session["Mail"];
            var id=db.Customers.Where(x=>x.Mail==email.ToString()).Select(x=>x.CustomerId).FirstOrDefault();
            var values = db.SalesTransactions.Where(x => x.Customerid == id).ToList();
            return View();
        }
    }
}