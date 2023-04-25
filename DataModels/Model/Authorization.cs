using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AuthorizationTb
    {
        [Key]
        public int auth_id { get; set; }

        [Display(Name ="Start Date")]
        public DateTime auth_start_date { get; set; }

        [Display(Name = "End Date")]
        public DateTime auth_end_date { get; set; }


        [Display(Name = "Number")]
        public string auth_number { get; set; }

        [Display(Name = "Type")]
        public int auth_type_id { get; set; }

        [ForeignKey("auth_type_id")]
        public AuthorizationType AuthorizationType { get; set; }

        [Display(Name = "Contract No.")]
        public int rent_id { get; set; }

        [ForeignKey("rent_id")]
        public Rent Rent { get; set; }

        [Display(Name = "Notes")]
        public string auth_notes { get; set; }


    }
}
