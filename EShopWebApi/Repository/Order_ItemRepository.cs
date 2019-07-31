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

		}
	}
}
