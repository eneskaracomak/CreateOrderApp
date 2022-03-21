
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
			var connStr = Parameters.ConnectionString;
            if (String.IsNullOrEmpty(connStr))
            {
				connStr = "Data Source=.;Initial Catalog=EcommerceTest;Trusted_Connection=TRUE;";

			}

			optionsBuilder.UseSqlServer(connStr);
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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//Department
			modelBuilder.Entity<Customer>()
						.HasData(
						 new Customer { IsActive = true, Name = "Enes",Surname="Karaçomak" ,Id = 1});
			modelBuilder.Entity<Adres>()
						.HasData(
						 new Adres { AdressDetail ="Atadan caddesi mehterler sokak 5/4 etlik Keçiören/ANKARA",Id=1 });
			modelBuilder.Entity<Product>()
					.HasData(
					 new Product { Name = "Kadýn Siyah Günlük Bot TR0400KR",Quantity = 1,Stock = 1 ,Id = 1});


		}

	}
	

}
// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.DataAccess\Concrete\EntityFramework\Contexts
