using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }

        public bool Status { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}