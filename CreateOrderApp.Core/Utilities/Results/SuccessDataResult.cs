
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Core.Utilities.Results
{
	public class SuccessDataResult<T>:DataResult<T> 
	{
		public SuccessDataResult(T data) : base(data, true)
		{
		}
		public SuccessDataResult(T data, string message) : base(data, true, message)
		{
		}
		public SuccessDataResult(string message) : base(default, true, message)
		{
		}
		public SuccessDataResult() : base(default, true)
		{
		}
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Utilities\Results 
