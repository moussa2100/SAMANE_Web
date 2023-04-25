using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class UsersPermissions
    {
        [Key]
        public int per_id { get; set; }

        public string userID { get; set; }

        public string per_module { get; set; }

        public string per_func { get; set; }

    }
}
