using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Classes
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemID { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
        public Invoice Invoice { get; set; }
    }
}