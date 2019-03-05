using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee : User
    {
        [Key]
        public int EmployeeNumber { get; set; }
        public bool ConfirmPickup { get; set; }
    }
}