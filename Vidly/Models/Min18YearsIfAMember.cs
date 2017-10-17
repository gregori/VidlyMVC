using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;

            if (customer.MembershipTypeId == MembershipType.Unknown || 
                customer.MembershipTypeId == MembershipType.PayAsYouGo) // paga conforme uso
                return ValidationResult.Success;

            if (customer.Birthdate == null) // se o usuário não informou Birthdate
                return new ValidationResult("O campo Data de Nascimento é obrigatório");

            // cálculo básico de idade
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("O cliente deve ter, ao menos, 18 anos, para associar-se.");
        }
    }
}