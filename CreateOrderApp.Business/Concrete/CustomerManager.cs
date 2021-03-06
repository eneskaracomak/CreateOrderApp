
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
	public class CustomerManager : ICustomerService 
	{
		 private ICustomerDal _customerDal; 
		 public CustomerManager(ICustomerDal customerDal) 
		{
			_customerDal = customerDal;
		}

		public IResult Add(Customer entity) 
		{
			_customerDal.Add(entity); 
			return new SuccessResult(Messages.CustomerAdded); 
		}

		public IResult Update(Customer entity) 
		{
			_customerDal.Update(entity); 
			return new SuccessResult(Messages.CustomerUpdated); 
		}

		public IResult Delete(Customer entity) 
		{
			_customerDal.Delete(entity); 
			return new SuccessResult(Messages.CustomerDeleted); 
		}

		public IDataResult<Customer> GetById(int customerId) 
		{
			return new SuccessDataResult<Customer>(_customerDal.Get(x=>x.Id == customerId)); 
		}

		public IDataResult<List<Customer>> GetList() 
		{
			return new SuccessDataResult<List<Customer>>(_customerDal.GetList().ToList());
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Concrete 
