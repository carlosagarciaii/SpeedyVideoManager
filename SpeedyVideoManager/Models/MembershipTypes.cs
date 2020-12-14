using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SpeedyVideoManager.Models
{
    public class MembershipTypes
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string MembershipType { get; set; }
        
        public decimal Price { get; set; }
        public int DurationMonths { get; set; }
        public decimal Discount { get; set; }



    }
}