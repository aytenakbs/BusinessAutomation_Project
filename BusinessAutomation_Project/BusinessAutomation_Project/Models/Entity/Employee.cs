using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebGrease.Css.Ast.Selectors;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Surname { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(230)]
        public string Image { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Mail { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }
        public int Departmentid { get; set; }
        public virtual Department Department { get; set; }
    }
}