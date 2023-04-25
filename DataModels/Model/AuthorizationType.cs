using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AuthorizationType
    {
        [Key]
        public int auth_type_id { get; set; }

        [Display(Name = "Start Date")]
        public string auth_type_value { get; set; }

    }
}
