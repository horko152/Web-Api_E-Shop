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
    [Route("api/order_item")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
		Order_ItemRepository order_itemRepository;

		public OrderItemController(Order_ItemRepository order_itemRepository)
		{
			this.order_itemRepository = order_itemRepository;
		}
		[HttpGet]
		[Route("~/api/order_items")]
		public IQueryable<Order_Item> GetAll()
		{
			return order_itemRepository.GetAll();
		}

		[HttpGet("{id:int}")]
		public Order_Item GetById([FromRoute]int id)
		{
			return order_itemRepository.GetById(id);
		}

		[HttpPost]
		public void Create([FromBody]Order_Item order_item)
		{
			order_itemRepository.Create(order_item);
		}
		[HttpPut("{id}")]
		public void Update([FromRoute]int id, [FromBody]Order_Item order_item)
		{
			order_itemRepository.Update(id, order_item);
		}
		[HttpDelete("{id}")]
		public void Delete([FromRoute]int id)
		{
			order_itemRepository.Delete(id);
		}
	}
}