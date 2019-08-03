using EShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi.Repository
{
	public class OrderRepository : GeneralRepository<Order>
	{
		public OrderRepository(EShopDbContext DbContext) : base(DbContext)
		{
			this.DbContext = DbContext;
		}
		public int CreateOrder(Order Entity)
		{
			DbContext.Add(Entity);
			DbContext.SaveChanges();
			return Entity.Id;
		}
		public IQueryable<Order> GetOrderByUserId(int id)
		{
			IQueryable<Order> orders = DbContext.Orders.ToList().Where(x => x.User_Id == id).AsQueryable();
			if(orders != null)
			{
				return orders;
			}
			else
			{
				throw new ArgumentException();
			}
			//return DbContext.Orders.ToList().Where(x => x.User_Id == id).AsQueryable();
		} 
	}
}
