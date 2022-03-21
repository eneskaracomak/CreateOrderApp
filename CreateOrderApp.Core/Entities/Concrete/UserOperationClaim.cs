
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;
using CreateOrderApp.Core.Entities;

namespace CreateOrderApp.Core.Entities.Concrete
{
	public class UserOperationClaim:IEntity 
	{
		public int Id { get; set; } 
		public int UserId { get; set; } 
		public int OperationClaimId { get; set; } 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\Entities\Concrete 
