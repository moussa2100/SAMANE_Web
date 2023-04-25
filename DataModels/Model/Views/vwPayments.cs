using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Views
{
    public class vwPayments
    {
        public double Total { get; set; }

        [Key]
        public int Contract { get; set; }
    }
}
