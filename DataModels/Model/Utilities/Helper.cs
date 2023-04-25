using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Utilities
{
    public  class Helper
    {


        private readonly WebApplication1.Models.AppDbContext _context;

        public Helper(WebApplication1.Models.AppDbContext context)
        {
            _context = context;
        }


        public Carr GetCarr(string pl_num)
        {

            return _context.Cars
                .Include( d => d.CarModel)
                .FirstOrDefault(c => c.Plate_Number == pl_num);
        }
    }
}
