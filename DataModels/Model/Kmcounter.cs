
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Utilities;


namespace WebApplication1.Models
{
    public class Kmcounter
    {
        [Key]
        public int kmcounter_id { get; set; }

        public int car_id { get; set; }

        [ForeignKey("car_id ")]
        public Carr Carr { get; set; }

        [Display(Name = "Kilometers")]
        public double counter_km { get; set; }

        [Display(Name = "Reason")]
        public kmEnum KmEnum { get; set; }

        [Display(Name = "Date")]
        public DateTime counter_date { get; set; }

        [Display(Name ="Notes")]
        public  string counter_notes { get; set; }

        [ScaffoldColumn(false)]
        public DateTime createdAt { get; set; }

        [ScaffoldColumn(false)]
        public int user_id { get; set; }
    }
}
