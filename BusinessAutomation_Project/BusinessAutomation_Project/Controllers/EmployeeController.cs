using BusinessAutomation_Project.Models.Entity;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace BusinessAutomation_Project.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        Context db = new Context();

        public ActionResult Index()
        {
            var values = db.Employees.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            List<SelectListItem> value1 = (from x in db.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.DepartmentId.ToString()

                                           }).ToList();
            ViewBag.dgr1 = value1;
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee p)
        {
            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string scape = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/images/" + filename + scape;
                Request.Files[0].SaveAs(Server.MapPath(path));
                p.Image = "/images/" + filename + scape;
            }
            db.Employees.Add(p);
            db.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult GetEmployee(int id)
        {
            List<SelectListItem> value2 = (from x in db.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.Name,
                                               Value = x.DepartmentId.ToString()

                                           }).ToList();
            ViewBag.dgr2 = value2;
            var value = db.Employees.Find(id);
            return View(value);
        }

        public ActionResult UpdateEmployee(Employee e)
        {
            if (Request.Files.Count > 0)
            {
                string filename = Path.GetFileName(Request.Files[0].FileName);
                string scape = Path.GetExtension(Request.Files[0].FileName);
                string path = "~/images/" + filename + scape;
                Request.Files[0].SaveAs(Server.MapPath(path));
                e.Image = "/images/" + filename + scape;
            }
            var empl = db.Employees.Find(e.EmployeeId);
            empl.Name = e.Name;
            empl.Surname = e.Surname;
            empl.Departmentid = e.Departmentid;
            empl.Image = e.Image;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EmployeeList()
        {
            var values = db.Employees.ToList();
            return View(values);
        }
    }
}

