using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string SerialNo { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string RotationNo { get; set; }
        public DateTime Date { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string TaxOffice { get; set; }
        public DateTime Time { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Deliverer { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Recipient { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}