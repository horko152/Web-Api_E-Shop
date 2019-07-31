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

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseNpgsql("Host=ec2-54-217-219-235.eu-west-1.compute.amazonaws.com;Port=5432;Database=d823iprm3nkr5a;Username=gvucvkzmaktram; Password=b959f57f2f1587e1f044fdee1ad86b69e827cc07fb71ea269a7decf8368ab3d8;Use SSL Stream = True; SSL Mode = Require; TrustServerCertificate = True");
		}
	}
}
