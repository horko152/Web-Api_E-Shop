using System;
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

		[HttpGet]
		[Route("~/api/orders")]
		public IQueryable<Order> GetAll()
		{
			return orderRepository.GetAll();
		}

		[HttpGet("{id:int}")]
		public Order GetById([FromRoute]int id)
		{
			return orderRepository.GetById(id);
		}

		[HttpPost]
		public void Create([FromBody]Order order)
		{
			orderRepository.Create(order);
		}

		[HttpPut("{id}")]
		public void Update([FromRoute]int id, [FromBody]Order order)
		{

			orderRepository.Update(id, order);
		}

		[HttpDelete("{id}")]
		public void Delete([FromRoute]int id)
		{
			orderRepository.Delete(id);
		}

	}
}