
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Utilities.Results;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.Abstract
{
	public interface IAdreService 
	{
		IDataResult<Adres> GetById(int adreId); 
		IDataResult<List<Adres>> GetList();
		IResult Add(Adres adre); 
		IResult Delete(Adres adre); 
		IResult Update(Adres adre); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Abstract 
