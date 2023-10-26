using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Classes
{
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}