using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer : User
    {
        [Key]
        
        public string CustomerNumber { get; set; }
        public string ExtraDay {get; set;}
        public int Balance { get; set; }
        public string SuspendStartDate { get; set; }
        public string SuspendEndDAte { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        // --foreign keys--
        [ForeignKey("PickupDay")]
        public int PickupDay { get; set; }
    }
}