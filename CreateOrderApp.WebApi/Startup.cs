using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using CreateOrderApp.Business.DependencyResolvers.Autofac;
using CreateOrderApp.Core.Utilities.Security.Encyption;
using CreateOrderApp.Core.Utilities.Security.Jwt;
using CreateOrderApp.DataAccess.Constants;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace CreateOrderApp.WebApi 
{
	public class Startup 
	{
		public Startup(IConfiguration configuration) 
		{
			Configuration = configuration; 
		}

		public IConfiguration Configuration { get; }
		public ILifetimeScope AutofacContainer { get; private set; }

		public void ConfigureServices(IServiceCollection services) 
		{

			services.AddControllers(); 
			services.AddCors(options => 
			{
				 options.AddPolicy(name: "AllowOrigin",
				 configurePolicy: builder => builder.WithOrigins("http://localhost:3000"));
			}); 
			var tokenOptions = Configuration.GetSection(key: "TokenOptions").Get<TokenOptions>(); 
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme) 
			.AddJwtBearer(options => { 
			options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters 
			{ 
				ValidateIssuer = true, 
				ValidateAudience =true, 
				ValidateLifetime = true, 
				ValidIssuer = tokenOptions.Issuer, 
				ValidAudience = tokenOptions.Audience, 
				ValidateIssuerSigningKey = true, 
				IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey) 
			}; 
			});
			services.AddSwaggerGen(c =>
			{
		
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "CreateOrder API Doc", Version = "v1" });
			});
			var builder = new ContainerBuilder();

			builder.Populate(services);

			// Register your own things directly with Autofac
			builder.RegisterModule(new AutofacBusinessModule());

			AutofacContainer = builder.Build();

			// this will be used as the service-provider for the application!

			Parameters.ConnectionString = Configuration.GetConnectionString("CreateOrderAppDbContext");  
		}



		public void Configure(IApplicationBuilder app, IWebHostEnvironment env) 
		{
			if (env.IsDevelopment()) 
			{
				 app.UseDeveloperExceptionPage(); 
			}
			app.UseCors(builder => builder.WithOrigins("http://localhost:3000").AllowAnyHeader()); 
			app.UseHttpsRedirection(); 
			app.UseRouting(); 
			app.UseAuthentication(); 
			app.UseAuthorization(); 
			app.UseEndpoints(endpoints =>{ endpoints.MapControllers();});
			app.UseSwagger();
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "ApiDocument");
				c.RoutePrefix = "ApiDocument";

			});
		}
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.WebApi\ 
