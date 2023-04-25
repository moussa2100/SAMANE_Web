
using System.ComponentModel.DataAnnotations;


namespace WebApplication1.Models
{
    public class PaymentOptions
    {
        [Key]
        public int pay_id { get; set; }

        [Display(Name ="Payment Method")]
        [Required]
        public string pay_value { get; set; }

    }
}
