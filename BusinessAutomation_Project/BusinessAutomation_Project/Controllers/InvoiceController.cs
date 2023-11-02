using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class InvoiceController : Controller
    {
        // GET: Invoice
        Context db = new Context();
        public ActionResult Index()
        {
            var values = db.Invoices.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddInvoice()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddInvoice(Invoice i)
        {
            db.Invoices.Add(i);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult GetInvoice(int id)
        {
            var value = db.Invoices.Find(id);
            return View(value);
        }

        public ActionResult UpdateInvoice(Invoice i)
        {
            var value = db.Invoices.Find(i.InvoiceId);
            value.Date=i.Date;
            value.Deliverer=i.Deliverer;
            value.Recipient=i.Recipient;
            value.RotationNo=i.RotationNo;
            value.SerialNo=i.SerialNo;
            value.Time=i.Time;
            value.TaxOffice=i.TaxOffice;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult DetailInvoice(int id)
        {
            var values = db.InvoiceItems.Where(x => x.Invoiceid == id).ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult NewItem()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewItem(InvoiceItem p)
        {
            db.InvoiceItems.Add(p);
            db.SaveChanges();
            return RedirectToAction("DetailInvoice","Invoice");
        }

    }
}