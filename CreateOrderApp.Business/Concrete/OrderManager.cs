
	//*** EnesKaracomak  ***//
using CreateOrderApp.Business.Abstract;
using CreateOrderApp.Business.Constants;
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.DataAccess.Abstract;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CreateOrderApp.Business.Concrete
{
	public class OrderManager : IOrderService 
	{
		 private IOrderDal _orderDal; 
		 public OrderManager(IOrderDal orderDal) 
		{
			_orderDal = orderDal;
		}

		public IResult Add(Order entity) 
		{
			_orderDal.Add(entity); 
			return new SuccessResult(Messages.OrderAdded); 
		}

		public IResult Update(Order entity) 
		{
			_orderDal.Update(entity); 
			return new SuccessResult(Messages.OrderUpdated); 
		}

		public IResult Delete(Order entity) 
		{
			_orderDal.Delete(entity); 
			return new SuccessResult(Messages.OrderDeleted); 
		}

		public IDataResult<Order> GetById(int orderId) 
		{
			return new SuccessDataResult<Order>(_orderDal.Get(x=>x.Id == orderId)); 
		}

		public IDataResult<List<Order>> GetList() 
		{
			return new SuccessDataResult<List<Order>>(_orderDal.GetList().ToList());
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Concrete 
