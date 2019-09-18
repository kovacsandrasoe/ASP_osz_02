using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(10)]
        public string Plate { get; set; }

        [MaxLength(50)]
        public string Type { get; set; }

        [Range(0,1000)]
        public int HorsePower { get; set; }
    }
}
