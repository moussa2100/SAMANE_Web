using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Utilities
{
    public class ValidateCustmomerId :ValidationAttribute
    {



        public override bool IsValid(object value)
        {

         //   var _context = new AppDbContext();

           // string cust_id = value.ToString();

           // if (_context.Customers.Any(c => c.cust_num == cust_id))
          //  {
          //      return false;
          //  }

            return true;
        }
    }
}
