
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
	public class AdreManager : IAdreService 
	{
		 private IAdreDal _adreDal; 
		 public AdreManager(IAdreDal adreDal) 
		{
			_adreDal = adreDal;
		}

		public IResult Add(Adres entity) 
		{
			_adreDal.Add(entity); 
			return new SuccessResult(Messages.AdreAdded); 
		}

		public IResult Update(Adres entity) 
		{
			_adreDal.Update(entity); 
			return new SuccessResult(Messages.AdreUpdated); 
		}

		public IResult Delete(Adres entity) 
		{
			_adreDal.Delete(entity); 
			return new SuccessResult(Messages.AdreDeleted); 
		}

		public IDataResult<Adres> GetById(int adreId) 
		{
			return new SuccessDataResult<Adres>(_adreDal.Get(x=>x.Id == adreId)); 
		}

		public IDataResult<List<Adres>> GetList() 
		{
			return new SuccessDataResult<List<Adres>>(_adreDal.GetList().ToList());
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Concrete 
