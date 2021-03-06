
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.Abstract
{
	public interface ICustomerAdreService 
	{
		IDataResult<CustomerAdres> GetById(int customerAdreId); 
		IDataResult<List<CustomerAdres>> GetList();
		IResult Add(CustomerAdres customerAdre); 
		IResult Delete(CustomerAdres customerAdre); 
		IResult Update(CustomerAdres customerAdre); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Abstract 
