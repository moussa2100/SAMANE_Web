using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PaymentDescription
    {

        [Key]
        public int pay_desc_id { get; set; }

        [Display(Name = "Description")]
        [Required]
        public string pay_descriptione { get; set; }

        [Display(Name = " Message")]
        [Required]
        public string pay_type_message { get; set; }

        [Display(Name = " Type")]
        [Required]
        public string pay_desc_type { get; set; }

        [Display(Name = "Receive Message")]
        public string pay_desc_receive { get; set; }
    }
}
