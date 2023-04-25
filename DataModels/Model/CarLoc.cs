using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarLoc
    {
        [Key]
        public int carLoc_id { get; set; }

        [Display(Name = "Car Location")]
        public string carLoc_Value { get; set; }

    }
}
