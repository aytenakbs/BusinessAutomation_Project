using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        
        public short Stock { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(250)]
        public string Image { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }  
        public ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}