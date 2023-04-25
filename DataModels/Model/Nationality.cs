using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Nationality
    {
        [Key]
        public int nat_id { get; set; }

        [Display(Name ="Nationality")]
        [Required]
        public string nat_value { get; set; }
    }
}
