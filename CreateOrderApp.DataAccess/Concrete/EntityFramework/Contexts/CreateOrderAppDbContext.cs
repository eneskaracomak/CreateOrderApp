
	//*** EnesKaracomak  ***//
using CreateOrderApp.Core.Entities.Concrete;
using CreateOrderApp.DataAccess.Constants;
using CreateOrderApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace CreateOrderApp.DataAccess.Concrete.EntityFramework.Contexts 
{
	public class CreateOrderAppDbContext:DbContext 
	{
		 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
		{
			optionsBuilder.UseSqlServer(Parameters.ConnectionString);
		}

		public DbSet<Customer> Customer { get; set; }

		public DbSet<Adres> Adress { get; set; }

		public DbSet<CustomerAdres> CustomerAdress { get; set; }

		public DbSet<Product> Product { get; set; }

		public DbSet<OrderLine> OrderLine { get; set; }

		public DbSet<Order> Order { get; set; }

		public DbSet<User> Users { get; set; }

		public DbSet<OperationClaim> OperationClaims { get; set; }

		public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.DataAccess\Concrete\EntityFramework\Contexts
