
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.Abstract
{
	public interface IOrderLineService 
	{
		IDataResult<OrderLine> GetById(int orderLineId); 
		IDataResult<List<OrderLine>> GetList();
		IResult Add(OrderLine orderLine); 
		IResult Delete(OrderLine orderLine); 
		IResult Update(OrderLine orderLine); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Abstract 
