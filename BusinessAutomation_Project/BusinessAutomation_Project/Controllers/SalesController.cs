using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class SalesController : Controller
    {
        // GET: Sales
        Context db = new Context();

        public ActionResult Index()
        {
            var values = db.SalesTransactions.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSales()
        {
            List<SelectListItem> value1 = (from x in db.Products.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.ProductId.ToString()
                                           }).ToList();
            ViewBag.dgr1 = value1;

            List<SelectListItem> value2 = (from x in db.Customers.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name + " " + x.Surname,
                                               Value = x.CustomerId.ToString()
                                           }).ToList();
            ViewBag.dgr2 = value2;

            List<SelectListItem> value3 = (from x in db.Employees.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name + " " + x.Surname,
                                               Value = x.EmployeeId.ToString()
                                           }).ToList();
            ViewBag.dgr3 = value3;
            return View();
        }

        [HttpPost]
        public ActionResult AddSales(SalesTransaction s)
        {
            db.SalesTransactions.Add(s);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult GetSales(int id)
        {
            List<SelectListItem> value1 = (from x in db.Products.ToList()
                select new SelectListItem
                {
                    Text = x.Name,
                    Value = x.ProductId.ToString()
                }).ToList();
            ViewBag.dgr1 = value1;

            List<SelectListItem> value2 = (from x in db.Customers.ToList()
                select new SelectListItem
                {
                    Text = x.Name + " " + x.Surname,
                    Value = x.CustomerId.ToString()
                }).ToList();
            ViewBag.dgr2 = value2;

            List<SelectListItem> value3 = (from x in db.Employees.ToList()
                select new SelectListItem
                {
                    Text = x.Name + " " + x.Surname,
                    Value = x.EmployeeId.ToString()
                }).ToList();
            ViewBag.dgr3 = value3;

            var value = db.SalesTransactions.Find(id);
            return View(value);
        }

        public ActionResult UpdateSales(SalesTransaction s)
        {
            var value=db.SalesTransactions.Find(s.SalesId);
            value.Productid = s.Productid;
            value.Customerid=s.Customerid;
            value.Employeeid=s.Employeeid;
            value.Amount=s.Amount;
            value.Date=s.Date;
            value.Price=s.Price;
            value.Total=s.Total;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult DetailSales(int id)
        {
            var values = db.SalesTransactions.Where(x => x.SalesId == id).ToList();
            return View(values);
        }
    }
}