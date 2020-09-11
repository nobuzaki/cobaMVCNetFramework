using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CobaMVCNetFramework.Models
{
    public class MaxNumberInStock : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var movie = (Movie)validationContext.ObjectInstance;

            int stock = movie.Stock;

            if (stock == 0)
                return new ValidationResult("Number in Stock is required.");

            return ( stock >= 1 && stock <= 20)
                ? ValidationResult.Success
                : new ValidationResult("The field Number in Stock must be between 1 and 20.");
        }
    }
}