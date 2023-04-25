using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CustomerStatus
    {
        [Key]
        public int cust_st_id { get; set; }

        [Display(Name = "Customer Status")]
        [Required]
        public string cust_value { get; set; }
    }
}
