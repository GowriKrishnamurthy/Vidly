using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MemberAgeLimit: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId == 0 || customer.MembershipTypeId == 1)
                return ValidationResult.Success;

            if (customer.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            return (DateTime.Today.Year - customer.Birthdate.Value.Year) > 18 
                ? ValidationResult.Success 
                : new ValidationResult("Customer should be atleast 18 years old to have membership");
        }
    }
}