using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string emp_name { get; set; }

      
        public int Projectproj_id { get; set; }
        public virtual Project Project { get; set; }


    }
}
