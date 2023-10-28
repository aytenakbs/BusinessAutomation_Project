using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30)]
        public string Surname { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(20)]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Mail { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}