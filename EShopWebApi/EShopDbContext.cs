using EShopWebApi.Models;
using Microsoft.EntityFrameworkCore;
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

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=DESKTOP-MFSAQ2U;Database=EShopDbWebApi;Trusted_Connection=True;");
		}
	}
}
