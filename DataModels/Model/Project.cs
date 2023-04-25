using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Project
    {
        public Project()
        {
            Employees =new  List<Employee>();
        }
        [Key]
        public int proj_id { get; set; }

        public string proj_name { get; set; }

        public virtual IList<Employee> Employees { get; set; }
    }
}
