
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
	public class ProductManager : IProductService 
	{
		 private IProductDal _productDal; 
		 public ProductManager(IProductDal productDal) 
		{
			_productDal = productDal;
		}

		public IResult Add(Product entity) 
		{
			_productDal.Add(entity); 
			return new SuccessResult(Messages.ProductAdded); 
		}

		public IResult Update(Product entity) 
		{
			_productDal.Update(entity); 
			return new SuccessResult(Messages.ProductUpdated); 
		}

		public IResult Delete(Product entity) 
		{
			_productDal.Delete(entity); 
			return new SuccessResult(Messages.ProductDeleted); 
		}

		public IDataResult<Product> GetById(int productId) 
		{
			return new SuccessDataResult<Product>(_productDal.Get(x=>x.Id == productId)); 
		}

		public IDataResult<List<Product>> GetList() 
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\Concrete 
