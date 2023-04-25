using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Views
{
    public class vw_payments_total
    {
        [Key]
        [Display(Name = "Contract")]
        public int rent_id { get; set; }

        [Display(Name = "Type")]
        public string pay_type_value { get; set; }

        [Display(Name = "Method")]
        public string pay_value { get; set; }

        [Display(Name = "Description")]
        public string pay_desc_type { get; set; }

        public string Plate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Display(Name = "Date")]
        public DateTime pay_date { get; set; }

        [Display(Name = "Total")]
        public double pay_amount { get; set; }



    }
}
