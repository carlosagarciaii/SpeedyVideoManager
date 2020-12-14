using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpeedyVideoManager.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SpeedyVideoManager.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string ZipPostal { get; set; }


        [DisplayFormat(DataFormatString= "{0:d}")]
        public DateTime BirthDate { get; set; }



        public MembershipTypes MembershipType { get; set; }

        public int MembershipID { get; set; }





    }
}