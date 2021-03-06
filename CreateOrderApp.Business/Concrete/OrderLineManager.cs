
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
	public class OrderLineManager : IOrderLineService 
	{
		 private IOrderLineDal _orderLineDal; 
		 public OrderLineManager(IOrderLineDal orderLineDal) 
		{
			_orderLineDal = orderLineDal;
		}

		public IResult Add(OrderLine entity) 
		{
			_orderLineDal.Add(entity); 
			return new SuccessResult(Messages.OrderLineAdded); 
		}

		public IResult Update(OrderLine entity) 
		{
			_orderLineDal.Update(entity); 
			return new SuccessResult(Messages.OrderLineUpdated); 
		}

		public IResult Delete(OrderLine entity) 
		{
			_orderLineDal.Delete(entity); 
			return new SuccessResult(Messages.OrderLineDeleted); 
		}

		public IDataResult<OrderLine> GetById(int orderLineId) 
		{
			return new SuccessDataResult<OrderLine>(_orderLineDal.Get(x=>x.Id == orderLineId)); 
		}

		public IDataResult<List<OrderLine>> GetList() 
		{
			return new SuccessDataResult<List<OrderLine>>(_orderLineDal.GetList().ToList());
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Concrete 
