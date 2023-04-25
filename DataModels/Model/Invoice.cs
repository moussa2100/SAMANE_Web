using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Invoice
    {
        [Key]
        public int invoice_id { get; set; }

        [Display(Name = "Contract No.")]
        public int rent_id { get; set; }

        [ForeignKey("rent_id")]
        public Rent Rent { get; set; }

        [Display(Name = "Payment")]
        public int pay_id { get; set; }

        [ForeignKey("cust_id")]
        public Payment Payment { get; set; }

        [Display(Name = "Date")]
        public DateTime invoice_date { get; set; }

        [Display(Name = "Item")]
        public string invoice_item { get; set; }

        [Display(Name = "Description")]
        public string invoice_desc { get; set; }

        [Display(Name = "Amount")]
        public double invoice_amount { get; set; }

        [Display(Name = "VAT")]
        public double invoice_vat { get; set; }

        [Display(Name = "Total")]
        public double invoice_total { get; set; }

        [Display(Name = "Notes")]
        public string auth_notes { get; set; }
    }
}
