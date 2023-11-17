using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;
using Microsoft.Ajax.Utilities;
using Context = BusinessAutomation_Project.Models.Entity.Context;

namespace BusinessAutomation_Project.Controllers
{
    public class StatisticController : Controller
    {
        // GET: Statistic
        private Context db = new Context();
        public ActionResult Index()
        {
            var value1 = db.Customers.Count().ToString();
            ViewBag.d1 = value1;
            var value2 = db.Products.Count().ToString();
            ViewBag.d2 = value2;
            var value3 = db.Employees.Count().ToString();
            ViewBag.d3 = value3;
            var value4 = db.Categories.Count().ToString();
            ViewBag.d4 = value4;
            var value5 = db.Products.Sum(x => x.Stock).ToString();
            ViewBag.d5 = value5;
            var value6 = (from x in db.Products select x.Brand).Distinct().Count().ToString();
            ViewBag.d6 = value6;
            var value7 = db.Products.Count(x => x.Stock <= 20).ToString();
            ViewBag.d7 = value7;
            var value8 = (from x in db.Products orderby x.SalesPrice descending select x.Name).FirstOrDefault();
            ViewBag.d8 = value8;
            var value9 = (from x in db.Products orderby x.SalesPrice ascending select x.Name).FirstOrDefault();
            ViewBag.d9 = value9;
            var value10 = db.Products.GroupBy(x => x.Brand).OrderByDescending(x => x.Count()).Select(x => x.Key)
                .FirstOrDefault();
            ViewBag.d10 = value10;
            var value11 = db.Products.Where(x => x.Category.Name == "Beyaz Esya").Sum(x => x.Stock).ToString();
            ViewBag.d11 = value11;
            var value12 = db.Products.Where(x => x.Category.Name == "Telefon").Sum(x => x.Stock).ToString();
            ViewBag.d12 = value12;
            var value13 = db.Products.Where(x => x.ProductId == (db.SalesTransactions.GroupBy(y => y.Productid).OrderByDescending(z => z.Count()).Select(k => k.Key).FirstOrDefault())).Select(c => c.Name).FirstOrDefault();
            ViewBag.d13 = value13;
            var value14 = db.SalesTransactions.Sum(x => x.Total).ToString();
            ViewBag.d14 = value14;
            DateTime today = DateTime.Today;
            var value15 = db.SalesTransactions.Count(x => x.Date == today).ToString();
            ViewBag.d15 = value15;
            var value16 = db.SalesTransactions.Where(x => x.Date == today).Sum(x => (decimal?)x.Total).ToString();
            ViewBag.d16 = value16;
            return View();
        }

        public ActionResult SimpleTables()
        {
            var query = from x in db.Customers
                        group x by x.City
                into g
                        select new GroupClass
                        {
                            City = g.Key,
                            Total = g.Count()
                        };
            return View(query.ToList());
        }

        public PartialViewResult Partial1()
        {
            var query2 = from x in db.Employees
                         group x by x.Department.Name
                into g
                         select new GroupClass1
                         {
                             Department = g.Key,
                             Total = g.Count()
                         };
            return PartialView(query2.ToList());
        }

        public PartialViewResult Partial2()
        {
            var values = db.Customers.Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial3()
        {
            var values = db.Products.Take(5).ToList();
            return PartialView(values);
        }

        public PartialViewResult Partial4()
        {
            var query4 = from x in db.Products
                         group x by x.Brand
                into g
                         select new GroupClass3
                         {
                             Brand = g.Key,
                             Total = g.Count()
                         };
            return PartialView(query4.Take(6).ToList());

        }
    }
}