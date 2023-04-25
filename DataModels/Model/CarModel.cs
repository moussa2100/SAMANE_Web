using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarModel
    {
        [Key]
        public int carmod_id { get; set; }
        [Display(Name = "Car Model")]
        public string carmod_value { get; set; }


    }
}
