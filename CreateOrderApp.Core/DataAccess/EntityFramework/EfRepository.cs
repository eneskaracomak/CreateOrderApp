
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using CreateOrderApp.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CreateOrderApp.Core.DataAccess.EntityFramework
{
	public class EfRepository<TEntity,TContext>:IRepository<TEntity> 
	where TEntity : class, IEntity, new() 
	where TContext:DbContext,new() 
	{

		 public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null) 
		{
			 using (TContext context = new TContext()) 
			{
				 return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList(); 
			}
		}

		public TEntity Get(Expression<Func<TEntity, bool>> filter) 
		{
			 using (TContext context = new TContext()) 
			{
				 return context.Set<TEntity>().SingleOrDefault(filter); 
			}
		}

		public int Add(TEntity entity) 
		{
			 using (TContext context = new TContext()) 
			{
				 var addedEntity = context.Entry(entity); 
				 addedEntity.State = EntityState.Added; 
				 return context.SaveChanges(); 
			}
		}

		public int Update(TEntity entity) 
		{
			 using (TContext context = new TContext()) 
			{
				 var updatedEntity = context.Entry(entity); 
				 updatedEntity.State = EntityState.Modified; 
				 return context.SaveChanges(); 
			}
		}

		public int Delete(TEntity entity) 
		{
			 using (TContext context = new TContext()) 
			{
				 var deletedEntity = context.Entry(entity); 
				 deletedEntity.State = EntityState.Deleted; 
				 return context.SaveChanges(); 
			}
		}

	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\DataAccess\EntityFramework
