
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
	public class CustomerAdreManager : ICustomerAdreService 
	{
		 private ICustomerAdreDal _customerAdreDal; 
		 public CustomerAdreManager(ICustomerAdreDal customerAdreDal) 
		{
			_customerAdreDal = customerAdreDal;
		}

		public IResult Add(CustomerAdres entity) 
		{
			_customerAdreDal.Add(entity); 
			return new SuccessResult(Messages.CustomerAdreAdded); 
		}

		public IResult Update(CustomerAdres entity) 
		{
			_customerAdreDal.Update(entity); 
			return new SuccessResult(Messages.CustomerAdreUpdated); 
		}

		public IResult Delete(CustomerAdres entity) 
		{
			_customerAdreDal.Delete(entity); 
			return new SuccessResult(Messages.CustomerAdreDeleted); 
		}

		public IDataResult<CustomerAdres> GetById(int customerAdreId) 
		{
			return new SuccessDataResult<CustomerAdres>(_customerAdreDal.Get(x=>x.Id == customerAdreId)); 
		}

		public IDataResult<List<CustomerAdres>> GetList() 
		{
			return new SuccessDataResult<List<CustomerAdres>>(_customerAdreDal.GetList().ToList());
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Concrete 
