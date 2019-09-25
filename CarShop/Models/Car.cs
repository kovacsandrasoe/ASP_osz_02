using CarShop.Validations;
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

        [MaxLength(7, ErrorMessage = "Max 7 karakter lehet")]
        [Required(ErrorMessage = "Ez a mező kötelező")]
        [Display(Name = "Rendszám")]
        [PlateValidation]
        public string Plate { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Ez a mező kötelező")]
        [Display(Name = "Autó típusa")]
        public string Type { get; set; }

        [Range(50,1000, ErrorMessage = "Az érték legyen 50...1000 között")]
        [Required(ErrorMessage = "Ez a mező kötelező")]
        [Display(Name = "Teljesítmény (LE)")]
        public int HorsePower { get; set; }
    }
}
