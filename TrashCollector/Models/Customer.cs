﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
        public string Name { get; set; }
        public DateTime? ExtraDay {get; set;}
        public int Balance { get; set; }
        public DateTime? SuspendStartDate { get; set; }
        public DateTime? SuspendEndDAte { get; set; }
        public DayOfWeek PickupDay { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }


        
    }

   
}