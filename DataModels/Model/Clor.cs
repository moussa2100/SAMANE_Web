using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Clor
    {
        [Key]
        public int clor_id { get; set; }
        [Display(Name = "Car Color")]
        public string clor_val { get; set; }
    }
}
