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

		}
	}
}
