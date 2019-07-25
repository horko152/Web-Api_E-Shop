using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi.Models
{
	[Table("orders")]
	public class Order
	{
		//public Orders()
		//{
		//	this.Order_Items = new HashSet<Order_Items>();
		//}
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id")]
		public int Id { get; set; }
		[Required]
		[Column("date_of_creation")]
		public DateTime Date_Of_Creation { get; set; }
		[Column("comment")]
		public string Comment { get; set; }
		//[JsonIgnore]
		[Column("user_id")]
		public int User_Id { get; set; }
		[ForeignKey("User_Id")]
		[JsonIgnore]
		public User User { get; set; }
		[JsonIgnore]
		public ICollection<Order_Item> Order_Items { get; set; }
	}
}
