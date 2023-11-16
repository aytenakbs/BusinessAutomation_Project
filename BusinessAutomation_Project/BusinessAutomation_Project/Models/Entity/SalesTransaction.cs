using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class SalesTransaction
    {
        [Key]
        public int SalesId { get; set; }

        public int Productid { get; set; }
        public virtual Product Product { get; set; }
        public int Employeeid { get; set; }
        public virtual Employee Employee { get; set; }
        public int Customerid { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}