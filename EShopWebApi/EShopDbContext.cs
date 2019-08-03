using EShopWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi
{
	public class EShopDbContext : DbContext
	{
		public EShopDbContext() { }
		public DbSet<User> Users { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<Order_Item> Order_Items { get; set; }
		public DbSet<Product> Products { get; set;}
		public DbSet<Category> Categories { get; set; }

		//public EShopDbContext(DbContextOptions<EShopDbContext> options) : base(options)
		//{

		//}
		public static string GetConnectionString()
		{
			return Startup.ConnectionString;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if(!optionsBuilder.IsConfigured)
			{
				var con = GetConnectionString();
				optionsBuilder.UseSqlServer(con);
			}
		}
	}
}
