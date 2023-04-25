using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CarType
    {
        [Key]
        public int cartype_id { get; set; }

        [Display(Name = "Car Type")]
        public string cartype_value { get; set; }

        [Display(Name = "Car Model")]
        public int? carmod_id { get; set; }

        [ForeignKey("carmod_id")]
        public CarModel CarModel { get; set; }
    }
}
