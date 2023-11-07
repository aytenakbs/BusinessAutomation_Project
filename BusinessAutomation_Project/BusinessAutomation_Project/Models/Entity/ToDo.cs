using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Entity
{
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Title { get; set; }
        [Column(TypeName = "bit")]
        public bool Status { get; set; }

        public DateTime Date { get; set; }
    }
}