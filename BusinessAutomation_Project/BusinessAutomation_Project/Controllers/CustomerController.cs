using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        Context db =new Context();
        public ActionResult Index()
        {
            var values = db.Customers.Where(x=>x.Status==true).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCustomer(Customer c)
        {
            db.Customers.Add(c);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCustomer(int id)
        {
            var value=db.Customers.Find(id);
            value.Status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult GetCustomer(int id)
        {
            var value=db.Customers.Find(id);
            return View(value);
        }

        public ActionResult UpdateCustomer(Customer c)
        {
            if (!ModelState.IsValid)
            {
                return View("GetCustomer");
            }
            var values = db.Customers.Find(c.CustomerId);
            values.City=c.City;
            values.Mail=c.Mail;
            values.Name=c.Name;
            values.Surname=c.Surname;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult DetailCustomer(int id)
        {
            var values = db.SalesTransactions.Where(x => x.Customerid == id).ToList();
            var value1 = db.Customers.Where(x => x.CustomerId == id).Select(x => x.Name + " " + x.Surname).FirstOrDefault();
            ViewBag.dgr1 = value1;
            return View(values);
        }
    }
}