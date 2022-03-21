
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;
using CreateOrderApp.Core.Entities;

namespace CreateOrderApp.Core.Entities.Concrete
{
	public class User:IEntity 
	{
		public int Id { get; set; } 
		public string FirstName { get; set; } 
		public string LastName { get; set; } 
		public string Email { get; set; } 
		public byte[] PasswordHash { get; set; } 
		public byte[] PasswordSalt { get; set; } 
		public bool Status { get; set; } 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Entities\Concrete 
