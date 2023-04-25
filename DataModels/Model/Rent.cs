using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Rent
    {
        [Key]
        [Display(Name = "Contract Number")]
        public int rentId { get; set; }

        [Display(Name = "Car")]
        public int carID { get; set; }

        [ForeignKey("carID")]
        public Carr Carr { get; set; }

        [Display(Name = "Customer")]
        public int cust_id { get; set; }

        [ForeignKey("cust_id")]
        public Customerr Customerr { get; set; }

        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}")]
        [Display(Name = "Start Date")]
       //[DataType(DataType.Date)]
        [Required]
        public DateTime start_date { get; set; }

        [Display(Name = "End Date")]
        [Required]
        public DateTime end_date { get; set; }

        [Display(Name = "Current KM")]
        [Required]
        public double current_km { get; set; }

        [Display(Name = "Free KM")]
        [Required]
        public double free { get; set; }

        [Display(Name = "Allowed KM")]
        public double? free_km_total { get; set; }

        [Display(Name = "Open KM")]
        public double open_km { set; get; }

        [Display(Name = "Contract Type")]
        public int contract_type_id { get; set; }

        [ForeignKey("contract_type_id")]
        public ContractType ContractType { get; set; }

        [Display(Name = "City")]
        public string car_city { get; set; }

        [Display(Name = "Unit Price")]
        [Required]
        public double unit_price { get; set; }

        [Display(Name = "Unit Count")]
        [Required]
        public int units_count { get; set; }

        [Display(Name = "Extra Km")]
        [Required]
        public double extra_km { get; set; }

        [Display(Name = "Extra Hour")]
        public double? extra_hour { get; set; }

        [Display(Name ="Extra Days")]
        public int extra_days { get; set; }



        [Display(Name = "Extra Km Fees")]
        [Required]
        public double extra_km_fees { get; set; }

        [Display(Name = "Extra Hour Fees")]
        public double? extra_hour_fees { get; set; }

        [Display(Name = "Extra Days Fees")]
        public int extra_days_fees { get; set; }


        [Display(Name = "Advanced Payment")]
        public double? advanced_pay { get; set; }

        [Display(Name = "Notes")]
        public string notes { get; set; }

        [Display(Name = "End Contract Km")]
        public double? end_km { get; set; }

        [Display(Name = "Damages")]
        public string acciedent { get; set; }

        [Display(Name = "Net Amount")]
        public double? net_amount { get; set; }

        [Display(Name = "Disount")]
        public double? discount { get; set; }

        [Display(Name = "Total Price")]
        public double? price_amount { get; set; }

        [Display(Name = "VAT")]
        public double vat_amount { get; set; }

        [Display(Name = "Refund Amount")]
        public double? refund_amount { get; set; }

        [ForeignKey("ContractStatusId")]
        public ContractStatus ContractStatus { set; get; }

        [ForeignKey("Contract Status")]
        public int? ContractStatusId { set; get; }

        [Display(Name = "Transfer Fees")]
       
        public double? ChargeFees { set; get; }

        [Display(Name = "Pre-Paid Invoice Price")]
        public double? PrePaidInvoicePrice { set; get; }

        [Display(Name = "Pre-Paid Invoice Date")]
        public DateTime PrePaidInvoiceDate { set; get; }

        [Display(Name = "Theft Price")]
        public double? Theft_Price { set; get; }

        [Display(Name = "Fixed Body Price")]
        public double? Fixed_Body_Price { set; get; }

        [Display(Name = "Accident Price")]
        public double? Accident_Price { set; get; }

        [Display(Name = "Escape Price")]
        public double? Escape_Price { set; get; }

        [Display(Name = "Services Price")]
        public double? others_Price { set; get; }

        [Display(Name = "Services")]
        public string others { set; get; }

        [Display(Name = "Leave Fuel")]
        public double? LeaveFuel { set; get; }

        [Display(Name = "Back Fuel")]
        public double? BackFuel { set; get; }

        [Display(Name = "Extra Driver Name")]
        public string extra_driver_name { set; get; }

        [Display(Name = "IQAMA")]
        public string extra_iqama { set; get; }

        [Display(Name = "Licence End")]
        public DateTime? extra_licence_expire { set; get; }

        [Display(Name = "IQAMA End")]
        public DateTime? extra_iqama_expire { set; get; }

        [Display(Name = "Mobile")]
        public string extra_driver_mobile { set; get; }

        [Display(Name = "Signature")]
        public string rent_sign { set; get; }

    }
}
