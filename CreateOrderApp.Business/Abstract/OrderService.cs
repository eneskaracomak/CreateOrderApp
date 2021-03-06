
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.Abstract
{
	public interface IOrderService 
	{
		IDataResult<Order> GetById(int orderId); 
		IDataResult<List<Order>> GetList();
		IResult Add(Order order); 
		IResult Delete(Order order); 
		IResult Update(Order order); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Abstract 
