using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace BusinessAutomation_Project.Models.Classes
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
        public SalesTransaction SalesTransaction { get; set; }
        public Department Department { get; set; }
    }
}