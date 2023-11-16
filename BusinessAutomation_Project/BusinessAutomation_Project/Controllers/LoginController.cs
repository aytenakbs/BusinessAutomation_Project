using BusinessAutomation_Project.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BusinessAutomation_Project.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context db = new Context();
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
            return PartialView();
        }
        [HttpGet]
        public ActionResult CustomerLogin1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CustomerLogin1(Customer c)
        {
            var values = db.Customers.FirstOrDefault(x => x.Mail == c.Mail && x.Password == c.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.Mail, false);
                Session["Mail"] = values.Mail.ToString();
                return RedirectToAction("index", "CustomerPanel");
            }
            else
            {
                return RedirectToAction("index", "Login");
            }

        }
        [HttpGet]
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin a)
        {
            var values = db.Admins.FirstOrDefault(x => x.UserName == a.UserName && x.Password == a.Password);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName, false);
                Session["UserName"] = values.UserName.ToString();
                return RedirectToAction("index", "Category");
            }
            else
            {
                return RedirectToAction("index", "Login");
            }

        }
    }
}