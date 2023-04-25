using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ContractType
    {
        [Key]
        public int contract_type_id { get; set; }

        public string contract_type_val { get; set; }

        public int days_count { get; set; }
    }
}
