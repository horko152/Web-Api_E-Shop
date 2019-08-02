﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EShopWebApi.Models;
using EShopWebApi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopWebApi.Controllers
{
	[Route("api/order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
		OrderRepository orderRepository;
		public OrderController(OrderRepository orderRepository)
		{
			this.orderRepository = orderRepository;
		}

		///<summary>
		///Get All Orders
		///</summary>
		[HttpGet]
		[Route("~/api/orders")]
		public IQueryable<Order> GetAll()
		{
			return orderRepository.GetAll();
		}

		///<summary>
		///Get Order By Id
		///</summary>
		[HttpGet("{id:int}")]
		public Order GetById([FromRoute]int id)
		{
			return orderRepository.GetById(id);
		}

		///<summary>
		///Create Order
		///</summary>
		[HttpPost]
		public void Create([FromBody]Order order)
		{
			orderRepository.Create(order);
			HttpContext.Response.StatusCode = 201;
		}

		///<summary>
		///Update Order
		///</summary>
		[HttpPut("{id}")]
		public void Update([FromRoute]int id, [FromBody]Order order)
		{

			orderRepository.Update(id, order);
		}

		///<summary>
		///Delete Order
		///</summary>
		/// <param name="id"></param> 
		[HttpDelete("{id}")] 
		public void Delete([FromRoute]int id)
		{
			orderRepository.Delete(id);
		}

	}
}