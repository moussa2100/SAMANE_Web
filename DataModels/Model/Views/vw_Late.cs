using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Views
{
    public class vwLate
    {
        [Key]
        public int Contract { get; set; }

        public string Plate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public double Total { get; set; }

        public string Status { get; set; }

        public double Paid { get; set; }

        public double Due { get; set; }

        public double UnitPrice { get; set; }

        public int LateDays { get; set; }

        public double LateDue { get; set; }

        public double TotalDue { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public double CLateDays { get; set; }
    }
}
