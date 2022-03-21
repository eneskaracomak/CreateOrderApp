
	//*** EnesKaracomak  ***//
using Autofac;
using CreateOrderApp.Business.Abstract;
using CreateOrderApp.Business.Concrete;
using CreateOrderApp.Core.Utilities.Security.Jwt;
using CreateOrderApp.DataAccess.Abstract;
using CreateOrderApp.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreateOrderApp.Business.DependencyResolvers.Autofac
{
	public class AutofacBusinessModule:Module
	{
		protected override void Load(ContainerBuilder builder)
		{
			builder.RegisterType<CustomerManager>().As<ICustomerService>();
			builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();
			builder.RegisterType<AdreManager>().As<IAdreService>();
			builder.RegisterType<EfAdreDal>().As<IAdreDal>();
			builder.RegisterType<CustomerAdreManager>().As<ICustomerAdreService>();
			builder.RegisterType<EfCustomerAdreDal>().As<ICustomerAdreDal>();
			builder.RegisterType<ProductManager>().As<IProductService>();
			builder.RegisterType<EfProductDal>().As<IProductDal>();
			builder.RegisterType<OrderLineManager>().As<IOrderLineService>();
			builder.RegisterType<EfOrderLineDal>().As<IOrderLineDal>();
			builder.RegisterType<OrderManager>().As<IOrderService>();
			builder.RegisterType<EfOrderDal>().As<IOrderDal>();
			builder.RegisterType<JwtHelper>().As<ITokenHelper>();
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Business\DependencyResolvers\Autofac 
