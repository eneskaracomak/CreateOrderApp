
	//*** EnesKaracomak  ***//
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
using CreateOrderApp.Core.Entities;

namespace CreateOrderApp.Core.DataAccess
{
	public interface IRepository<TEntity> where TEntity:class , IEntity,new() 
	{
		 List<TEntity> GetList(Expression<Func<TEntity,bool>> filter = null); 
		 TEntity Get(Expression<Func<TEntity, bool>> filter); 
		 int Add(TEntity entity); 
		 int Update(TEntity entity); 
		 int Delete(TEntity entity); 
	}
}
	// C:\Users\enesk\source\repos\CreateOrderApp\CreateOrderApp.Core\DataAccess 
