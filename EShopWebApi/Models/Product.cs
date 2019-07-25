using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi.Models
{
	[Table("products")]
	public class Product
	{
		//public Products()
		//{
		//	this.Order_Items = new HashSet<Order_Items>();
		//}
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id")]
		public int Id { get; set; }
		[Required]
		[Column("name")]
		public string Name { get; set; }
		[Required]
		[Column("price")]
		public decimal Price { get; set; }
		[Required]
		[Column("quantity")]
		public int Quantity { get; set; }
		[Column("description")]
		public string Description { get; set; }
		[JsonIgnore]
		[Column("category_id")]
		public int Category_Id { get; set; }
		[ForeignKey("Category_Id")]
		public virtual Category Category { get; set; }
		[JsonIgnore]
		public virtual ICollection<Order_Item> Order_Items { get; set; }


	}
}
