using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BusinessAutomation_Project.Models.Classes
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        public string Mail { get; set; }
        public SalesTransaction SalesTransaction { get; set; }
    }
}