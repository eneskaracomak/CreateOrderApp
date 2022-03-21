
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Core.Utilities.Security.Jwt
{
	public class TokenOptions
	{
		public string Audience { get; set; }
		public string Issuer { get; set; }
		public int AccessTokenExpiration { get; set; }
		public string SecurityKey { get; set; }
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Utilities\Security\Jwt 
