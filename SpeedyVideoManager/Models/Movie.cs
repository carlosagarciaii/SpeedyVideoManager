using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SpeedyVideoManager.Models
{
    public class Movie
    {

        public int ID { get; set; }
        [Required]
        public string Title {get;set;}
        public int ReleaseYear { get; set; }
        public int RuntimeMinutes { get; set; }
        public string Summary { get; set; }
        public string Details { get; set; }





    }
}