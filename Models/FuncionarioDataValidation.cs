using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SPT.Models
{
    public class FuncionarioDataValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var funcionario = (Funcionario)validationContext.ObjectInstance;
            return null;
        }
    }
}
