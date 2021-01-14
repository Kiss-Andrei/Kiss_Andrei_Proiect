using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kiss_Andrei_Proiect.Models
{
    public class Bikes
    {
        public int ID { get; set; }
        [Display(Name = "Bike Name")]
        public string BikeName { get; set; }
        [Display(Name ="Bike Type")]
        public string BiketType { get; set; }
        public decimal BikeSpeeds { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }
        public DateTime SellingDate { get; set; }

    }
}
