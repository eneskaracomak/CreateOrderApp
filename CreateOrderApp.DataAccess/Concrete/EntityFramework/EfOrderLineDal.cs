
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.DataAccess.EntityFramework;
using CreateOrderApp.DataAccess.Abstract;
using CreateOrderApp.DataAccess.Concrete.EntityFramework.Contexts;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.DataAccess.Concrete.EntityFramework
{
	public class EfOrderLineDal:EfRepository<OrderLine,CreateOrderAppDbContext>,IOrderLineDal
	{
	// Special operations write here! 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.DataAccess\Concrete\EntityFramework 
