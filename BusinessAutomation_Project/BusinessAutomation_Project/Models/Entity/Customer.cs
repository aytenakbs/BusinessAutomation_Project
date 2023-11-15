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
        [Required(ErrorMessage="Bu alan zorunludur")]
        [Column(TypeName = "varchar")]
        [StringLength(30,ErrorMessage = "Girilen isim en fazla 30 karakter olabilir")]
        public string Name { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(30, ErrorMessage = "Bu alan en fazla 30 karakter olabilir")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Surname { get; set; }
        [Column(TypeName = "varchar")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(20, ErrorMessage = "Bu alan en fazla 20 karakter olabilir")]
        public string City { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50, ErrorMessage = "Bu alan en fazla 50 karakter olabilir")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Mail { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10, ErrorMessage = "Bu alan en fazla 10 karakter olabilir")]
        [Required(ErrorMessage = "Bu alan zorunludur")]
        public string Password { get; set; }
        public bool Status { get; set; }
        public ICollection<SalesTransaction> SalesTransactions { get; set; }
    }
}