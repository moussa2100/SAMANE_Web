using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class ContractStatus
    {
        [Key]
        public int ContractId { get; set; }

        [Display(Name="Status")]
        public string Name { set; get; }
    }
}
