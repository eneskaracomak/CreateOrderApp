
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.DataAccess;
using CreateOrderApp.Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.DataAccess.Abstract
{
	public interface IUserDal:IRepository<User>
	{
		List<OperationClaim> GetUserClaims(User user);
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.DataAccess\Abstract 
