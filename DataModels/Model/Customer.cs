

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Utilities;


namespace WebApplication1.Models
{
    public class Customerr
    {
        [Key]
        public int Cust_id { get; set; }

        [Display(Name ="Name")]
        [Required]
        public string Cust_name { get; set; }

        [Display(Name = "Nationality")]
        public int nat_id { get; set; }
        
        [ForeignKey("nat_id")]
        public  Nationality Nationality { get; set; }


        [Display(Name = "Company")]
        public string company_name { get; set; }

        [Required]
        [ValidateCustmomerId()]
        [Display(Name = "Identity Num")]
        public string cust_num { get; set; }

        [Display(Name = "ID Copy")]
        public string cust_id_copy { get; set; }

        [Display(Name = "Identity Expire")]
        //[DataType(DataType.Date)]
       // [DisplayFormat( DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime? cust_num_expire { get; set; }

        [Display(Name = "City")]
        public string cust_city { get; set; }

        [Required]
        [Display(Name = "Licence No")]
        public string lice_num { get; set; }

        [Display(Name = "Licence Expire")]
      
       // [DataType(DataType.Date)]
        public DateTime? lice_exp { get; set; }

        [Display(Name = "Licence City")]
        public string lice_city { get; set; }

        [Display(Name = "Home Address")]
        public string home_addr { get; set; }

        [Display(Name = "Work Address")]
        public string comp_addr { get; set; }
        
        [Display(Name = "Mobile")]
        public string mobile { get; set; }

        [Display(Name = "Phone")]
        public string phone { get; set; }

        [Display(Name = "Mail")]
        public string mail { get; set; }

        [Display(Name = "Notes")]
        public string notes { get; set; }

      //  [Display(Name = "BirthDate")]
       // [DataType(DataType.Date)]
        public DateTime? birth_date { get; set; }

        [Display(Name = "Company VAT")]
        public string company_vat { get; set; }

        [Display(Name = "Status")]
        public int cust_st_id { get; set; }
        [ForeignKey("cust_st_id")]
        public CustomerStatus CustomerStatus { get; set; }

    }
}
