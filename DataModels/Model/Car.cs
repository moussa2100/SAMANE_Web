
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Carr
    {
        [Key]
        public int car_id { get; set; }

        [Display(Name = "Plate Num")]
        public string Plate_Number { get; set; }


        [Display(Name = "Car Type")]
        public int cartype_id { get; set; }

        [ForeignKey("cartype_id")]
        public CarType CarType { get; set; }

        [Display(Name = "Car Model")]
        public int carmod_id { get; set; }

        [ForeignKey("carmod_id")]
        public CarModel CarModel { get; set; }

        [Display(Name = "Color")]
        public int? clor_id { get; set; }

        [ForeignKey("clor_id")]
        public Clor Clor { get; set; }

        [Display(Name = "Day Price")]
        public double day_price { get; set; }

        [Display(Name = "Week Price")]
        public double week_price { get; set; }

        [Display(Name = "Month Price")]
        public double month_price { get; set; }

        [Display(Name = "Hour Price")]
        public double? hour_price { get; set; }

        [Display(Name = "Kilometer price")]
        public double? Km_price { get; set; }

        [Display(Name = "Free Kilometers")]
        public double? free_km { get; set; }

        [Display(Name = "Free Hour")]
        public double? Free_Hour { set; get; }

        [Display(Name = "Car Kilometer")]
        public double? car_km { get; set; }

        [Display(Name = "Year")]
        public int car_year { get; set; }

        [Display(Name = "Licence Num")]
        public string lice_num { get; set; }

        [Display(Name = "Licence Expire")]
       // [DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? lice_exp { get; set; }

        [Display(Name = "Insurane Expir")]
        public DateTime? insurane_exp { get; set; }

        [Display(Name = "Status")]
        public int status_id { get; set; }

        [ForeignKey("status_id")]
        public CarStatus CarStatus { get; set; }

        public int? userId { get; set; }

        [ForeignKey("fueltype_id")]
        public FuelType FuelType { set; get; }

        [Display(Name ="Fuel Type")]
        public int? fueltype_id { set; get; }

        [Display(Name = "Insurance Company")]
        public string insurance_company{ get; set; }

        [Display(Name = "Insurance Number")]
        public string insurance_num { get; set; }

        [Display(Name = "Accident 100% Fees")]
        public double? accident_fees { get; set; }



        [Display(Name = "Location")]
        public int? carLoc_id { get; set; }

        [ForeignKey("carLoc_id")]
        public CarLoc CarLoc { get; set; }


        public DateTime? created_at { get; set; }

        public DateTime? last_update { get; set; }

        [ScaffoldColumn(false)]
        public int? row_status { get; set; }

        public IList<Rent >Rents { get; set; }

    }
}
