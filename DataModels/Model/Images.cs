using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace DataModels.Model
{
    public class Images
    {
        public int Id { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        [DisplayName("Images")]
        public int carTypelId { get; set; }
        [ForeignKey("carModelId")]
        public CarType carType { get; set; }

    }
}
