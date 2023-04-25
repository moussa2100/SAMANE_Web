using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Payment_Type
    {
        [Key]
        public int pay_type_id { get; set; }

        [Display(Name = "Payment Type")]
        [Required]
        public string pay_type_value { get; set; }

       
    }
}
