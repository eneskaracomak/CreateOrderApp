
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace CreateOrderApp.Core.CrossCuttingConserns.Validation
{
	public class ValidationTool 
	{
		public static void Validate(IValidator validator,IValidationContext entity)
		{
			var result = validator.Validate(entity);
			if (!result.IsValid)
				throw new ValidationException(result.Errors);
		}
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\CrossCuttingConserns\Validation 
