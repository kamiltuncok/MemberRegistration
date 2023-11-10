using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Validation.FluentValidation
{
    public class ValidatiorTool
    {
        public static void FluentValidate<T>(IValidator<T> validator, T entity)
        {
            // Validate the entity using FluentValidation
            ValidationResult result = validator.Validate(entity);

            if (!result.IsValid)
            {
                // If validation fails, throw a ValidationException with the errors
                throw new ValidationException(result.Errors);
            }
        }
    }
}
