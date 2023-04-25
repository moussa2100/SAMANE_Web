using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Payment
    {
        [Key]
        [Display(Name = "Document Number")]
        public int pay_id { get; set; }

        [Display(Name = "Contract Number")]
        [Required]
        public int rent_id { get; set; }

        [ForeignKey("rent_id")]
        public Rent Rent { get; set; }

        [Display(Name = "Payment Type")]
        [Required]
        public int pay_type_id { get; set; }

        [ForeignKey("pay_type_id")]
        public Payment_Type Payment_Type { get; set; }

        [Display(Name = "Payment Method")]
        [Required]
        public int pay_method_id { get; set; }

        [ForeignKey("pay_method_id")]
        public PaymentOptions PaymentOptions{ get; set; }

        [Display(Name = "Description")]
        [Required]
        public int pay_desc_id { get; set; }

        [ForeignKey("pay_desc_id")]
        public PaymentDescription PaymentDescription { get; set; }

        [Display(Name = "Amount")]
        public double pay_amount { get; set; }

        [Display(Name = "Date")]
        public DateTime pay_date { get; set; }

        [Display(Name = "Notes")]
        public string pay_notes { get; set; }

        [Display(Name = "User ID")]
        public double? user_id { get; set; }

        [Display(Name = "Created at")]
        public DateTime? pay_created_at { get; set; }


    }
}
