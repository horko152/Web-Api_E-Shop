using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShopWebApi.Models
{
	[Table("users")]
	public class User
	{
		//public Users()
		//{
		//	this.Orders = new HashSet<Orders>();
		//}
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Column("id")]
		public int Id { get; set; }
		[Required]
		[Column("login")]
		public string Login { get; set; }
		[Required]
		[Column("password")]
		public string Password { get; set; }
		[Required]
		[Column("date_of_creation")]
		public DateTime Date_Of_Creation { get; set;}
		[Required]
		[Column("status")]
		public int Status { get; set; }
		[JsonIgnore]
		public ICollection<Order> Orders { get; set; }
	}
}
