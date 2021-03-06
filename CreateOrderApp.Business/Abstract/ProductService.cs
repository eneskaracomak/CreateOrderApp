
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.Abstract
{
	public interface IProductService 
	{
		IDataResult<Product> GetById(int productId); 
		IDataResult<List<Product>> GetList();
		IResult Add(Product product); 
		IResult Delete(Product product); 
		IResult Update(Product product); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Abstract 
