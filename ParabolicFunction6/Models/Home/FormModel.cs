using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using ParabolicFunction6.Attributes;
using System.ComponentModel.DataAnnotations;

namespace ParabolicFunction6.Models
{
    public class FormModel
    {

        
        [Required(ErrorMessage = "The field must be set")]
        [Display(Name = "First coefficient")]
        public double koef_a { get; set; }
        [Required(ErrorMessage = "The field must be set")]
        [Display(Name = "Second coefficient")]
        public double koef_b { get; set; }

        [Required(ErrorMessage = "The field must be set")]
        [Display(Name = "Third coefficient")]
        public double koef_c { get; set; }

        [PositiveValueValidation]
        [Required(ErrorMessage = "The field must be set")]
        [Display(Name = "Step")]
        public double step { get; set; }

        [Required(ErrorMessage = "The field must be set")]
        [Display(Name = "Left Bound")]
        public double lowerBound { get; set; }

        [Required(ErrorMessage = "The field must be set")]
        [Display(Name = "Right Bound")]
        public double upperBound { get; set; }
    }
}