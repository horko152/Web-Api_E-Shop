﻿using EShopWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
		public void UpdateOrder (int id, Order Entity)
		{
			var order = DbContext.Orders.FirstOrDefault(x => x.Id == id);
			//HttpResponseMessage responce = null;
			if (order != null)
			{
				order.Comment = Entity.Comment;
				order.User_Id = Entity.User_Id;
				DbContext.SaveChanges();
				//return responce = new HttpResponseMessage(HttpStatusCode.OK);
			}
			else
			{
				throw new ArgumentException();
			}
			//else return responce = new HttpResponseMessage(HttpStatusCode.NotFound);
		}
	}
}
