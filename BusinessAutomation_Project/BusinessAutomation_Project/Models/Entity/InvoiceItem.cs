using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class InvoiceItem
    {
        [Key]
        public int InvoiceItemId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(230)]
        public string Description { get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
        public Invoice Invoice { get; set; }
    }
}