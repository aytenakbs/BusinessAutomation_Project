using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Classes
{
    public class Invoice
    {
        [Key]
        public int InvoiceID { get; set; }
        public string SerialNo { get; set; }
        public string RotationNo { get; set; }
        public DateTime Date { get; set; }
        public string TaxOffice { get; set; }
        public DateTime Time { get; set; }
        public string Deliverer { get; set; }
        public string Recipient { get; set; }
        public ICollection<InvoiceItem> InvoiceItems { get; set; }
    }
}