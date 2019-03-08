using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public int EmployeeNumber { get; set; }
        public string Name { get; set; }
        public bool ConfirmPickup { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime PickupDay { get; set; }
        [ForeignKey("Id")]
        public int AspNetUsers { get; set; }
        public object ApplicationUserId { get; internal set; }
    }
}