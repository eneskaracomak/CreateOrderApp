
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;
using CreateOrderApp.Core.Entities.Concrete;

namespace CreateOrderApp.Core.Utilities.Security.Jwt
{
	public interface ITokenHelper
	{
		AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Utilities\Security\Jwt 
