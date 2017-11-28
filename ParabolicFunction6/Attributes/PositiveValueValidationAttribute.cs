using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ParabolicFunction6.Attributes
{
    public class PositiveValueValidationAttribute : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {               
            if ((double)value >= 0f )
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("The number sould be positive");
        }
    }
}