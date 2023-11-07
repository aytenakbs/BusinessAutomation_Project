using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class Detail
    {
        [Key]
        public int DetailId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(200)]
        public string PName { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(2000)]
        public string PInfo { get; set; }

    }
}