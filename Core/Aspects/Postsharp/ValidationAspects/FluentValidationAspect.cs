using Core.CrossCuttingConcerns.Validation.FluentValidation;
using FluentValidation;
using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Postsharp.ValidationAspects
{
    [Serializable]
    public class FluentValidationAspect : OnMethodBoundaryAspect
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }
        public override void OnEntry(MethodExecutionArgs args)
        {
            // Create an instance of the validator for the target type
            var validator = (IValidator)Activator.CreateInstance(_validatorType);

            // Iterate over the method arguments to find the parameter that implements IValidationContext
            foreach (var arg in args.Arguments)
            {
                if (arg is IValidationContext validationContext)
                {
                    // Validate the entity using FluentValidation
                    var validationResult = validator.Validate(validationContext);

                    // If validation fails, throw a ValidationException with the errors
                    if (!validationResult.IsValid)
                    {
                        throw new ValidationException(validationResult.Errors);
                    }
                }
            }
        }
        }
}
