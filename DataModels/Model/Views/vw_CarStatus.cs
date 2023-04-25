using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Views
{
    public class vw_CarStatus
    {
        [Key]
        [JsonProperty(PropertyName = "name")]
        public string Status { get; set; }

        [JsonProperty(PropertyName = "y")]
        public int CarsCount { get; set; }
    }
}
