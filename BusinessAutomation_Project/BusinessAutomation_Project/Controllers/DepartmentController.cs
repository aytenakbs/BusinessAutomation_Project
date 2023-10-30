using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessAutomation_Project.Models.Entity;

namespace BusinessAutomation_Project.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        private Context db = new Context();

        public ActionResult Index()
        {
            var values = db.Departments.Where(x => x.Status == true).ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddDepartment(Department d)
        {
            db.Departments.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index", "Department");
        }

        public ActionResult DeleteDepartment(int id)
        {
            var value = db.Departments.Find(id);
            value.Status = false;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult GetDepartment(int id)
        {
            var value = db.Departments.Find(id);
            return View(value);
        }

        public ActionResult UpdateDepartment(Department d)
        {
            var values = db.Departments.Find(d.DepartmentId);
            values.Status = d.Status;
            values.Name = d.Name;
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult DetailDepartment(int id)
        {
            var values = db.Employees.Where(x => x.Departmentid == id).ToList();
            var dName = db.Departments.Where(x => x.DepartmentId == id).Select(x => x.Name).FirstOrDefault();
            ViewBag.DepartmentName = dName;
            return View(values);
        }

        public ActionResult EmpSalesDepartment(int id)
        {
            var values=db.SalesTransactions.Where(x=>x.Employeeid==id).ToList();
            var eName = db.Employees.Where(x => x.EmployeeId == id).Select(x =>x.Name+" "+x.Surname).First();
            ViewBag.empName = eName;
            return View(values);
        }
    }
}