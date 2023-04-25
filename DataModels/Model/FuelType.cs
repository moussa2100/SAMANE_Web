using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class FuelType
    {
        [Key]
        public int Id { set; get; }

        public string Name { set; get; }
    }
}