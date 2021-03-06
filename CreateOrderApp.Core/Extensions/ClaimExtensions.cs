
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using System.Linq;

namespace CreateOrderApp.Core.Extensions
{
	public static class ClaimExtensions 
	{
		public static void AddEmail(this ICollection<Claim> claims, string email) 
		{
			claims.Add(new Claim(JwtRegisteredClaimNames.Email, email));
		}
		public static void AddName(this ICollection<Claim> claims, string name) 
		{
			claims.Add(new Claim(type:ClaimTypes.Name, value:name));
		}
		public static void AddNameIdentifier(this ICollection<Claim> claims, string nameIdentifier) 
		{
			claims.Add(new Claim(type: ClaimTypes.NameIdentifier, value: nameIdentifier));
		}
		public static void AddRoles(this ICollection<Claim> claims, string[] roles) 
		{
			List<string> roleList = roles.ToList();
			foreach (var role in roleList)
			{
				claims.Add(new Claim(type: ClaimTypes.Role, value: role));
			}
		}
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Extensions 
