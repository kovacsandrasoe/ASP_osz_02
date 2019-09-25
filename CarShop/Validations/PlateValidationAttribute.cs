using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarShop.Validations
{
    public class PlateValidationAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string plate = value as string;
            string[] pieces = plate.Split('-');
            return pieces.Length == 2 
                && plate[3] == '-'
                && pieces[0].Length == 3 
                && pieces[1].Length == 3;
        }

        public override string FormatErrorMessage(string name)
        {
            return "Nem érvényes rendszám!";
        }
    }
}
