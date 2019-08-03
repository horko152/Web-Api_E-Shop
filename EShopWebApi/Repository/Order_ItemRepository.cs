using EShopWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi.Repository
{
	public class Order_ItemRepository : GeneralRepository<Order_Item>
	{
		public Order_ItemRepository(EShopDbContext DbContext) : base(DbContext)
		{
			this.DbContext = DbContext;
		}
		public int CreateOrderItem(Order_Item Entity)
		{
			DbContext.Add(Entity);
			DbContext.SaveChanges();
			return Entity.Id;
		}
		public IQueryable<Order_Item> GetOrderItemByOrderId(int id)
		{
			IQueryable<Order_Item> order_items = DbContext.Order_Items.ToList().Where(x => x.Order_Id == id).AsQueryable();
			if (order_items != null)
			{
				return order_items;
			}
			else
			{
				throw new ArgumentException();
			}
		}
	}
}
