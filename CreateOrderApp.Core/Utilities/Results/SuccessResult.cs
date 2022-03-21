
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Core.Utilities.Results
{
	 public class SuccessResult : Result 
	{
		public SuccessResult() : base(true)
		{
		}
		public SuccessResult(string message) : base(true, message)
		{
		}
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Utilities\Results 
