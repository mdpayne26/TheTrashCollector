using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer : User
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ExtraDay {get; set;}
        public int Balance { get; set; }
        public string SuspendStartDate { get; set; }
        public string SuspendEndDAte { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public int UserRolesId { get; set; }
        public string PickupDay { get; set; }
    }
}