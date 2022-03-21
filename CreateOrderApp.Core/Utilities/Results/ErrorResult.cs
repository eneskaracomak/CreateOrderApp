
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Core.Utilities.Results
{
	 public class ErrorResult : Result 
	{
		public ErrorResult() : base(false)
		{
		}
		public ErrorResult(string message) : base(false, message)
		{
		}
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Utilities\Results 
