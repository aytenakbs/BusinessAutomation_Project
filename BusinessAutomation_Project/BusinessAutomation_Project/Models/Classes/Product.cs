using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Classes
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Brand { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public short Stock { get; set; }
        public decimal SalesPrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Image { get; set; }
        public Category Category { get; set; }  
        public SalesTransaction SalesTransaction { get; set; }
    }
}