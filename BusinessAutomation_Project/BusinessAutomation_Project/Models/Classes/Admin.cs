using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Classes
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string UserName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(10)]
        public string Password { get; set; }
        public string Authority { get; set; }
    }
}