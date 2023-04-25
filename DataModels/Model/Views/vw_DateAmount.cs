using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.Views
{
    public class vw_DateAmount
    {
        [Key]
        [JsonProperty(PropertyName = "name")]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd hh:mm}")]
        //[DataType(DataType.Date)]
        public string Date { get; set; }

        [JsonProperty(PropertyName = "y")]
       
        
        public double Amount { get; set; }

    }
}
