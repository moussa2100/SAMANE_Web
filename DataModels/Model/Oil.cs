using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Oil
    {
        [Key]
        public int oil_id { get; set; }

        [Display(Name ="Car")]
        public int car_id { get; set; }

        [ForeignKey("car_id")]
        public Carr Carr { get; set; }

        [Display(Name = "Date")]
        public DateTime oil_date { get; set; }


        [Display(Name = "KiloMeter")]
        public int oil_km{ get; set; }

        [Display(Name = "WorkShop")]
        public string oil_workshop { get; set; }

        [Display(Name = "Next KM")]
        public int oil_next{ get; set; }

        [Display(Name = "Oil Distance")]
        public int oil_distance { get; set; }

        [Display(Name = "Oil Type")]
        public string oil_type { get; set; }

        [Display(Name = "Amount")]
        public double oil_amount { get; set; }

        [Display(Name = "VAT")]
        public double oil_vat { get; set; }

        [Display(Name = "Total")]
        public double oil_total { get; set; }

        [Display(Name = "Notes")]
        public string oil_notes { get; set; }

    }
}
