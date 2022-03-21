
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.Abstract
{
	public interface ICustomerService 
	{
		IDataResult<Customer> GetById(int customerId); 
		IDataResult<List<Customer>> GetList();
		IResult Add(Customer customer); 
		IResult Delete(Customer customer); 
		IResult Update(Customer customer); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Abstract 
