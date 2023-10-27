using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string Description { get; set; }
        public DateTime Date  { get; set; }
        public decimal Total  { get; set; }
       
    }
}