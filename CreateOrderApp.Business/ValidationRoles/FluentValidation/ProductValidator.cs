
	//*** EnesKaracomak  ***//
using CreateOrderApp.Business.Constants;
using CreateOrderApp.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.ValidationRoles.FluentValidation
{
	public class ProductValidator:AbstractValidator<Product>
	{
		public ProductValidator()
		{
			//Sample role here. 
			//RuleFor(p => p.ProductName).NotEmpty().WithMessage(Messages.ProductNotEmpty);
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\ValidationRoles\FluentValidation 
