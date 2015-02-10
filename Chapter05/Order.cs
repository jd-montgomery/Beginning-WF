using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter04_OrderProcess
{
	public class Order
	{
		public Order()
		{
			this.Items = new List<OrderItem>();
		}

		public int OrderId { get; set; }
		public string Description { get; set; }
		public decimal TotalWeight { get; set; }
		public string ShippingMethod { get; set; }

		public List<OrderItem> Items { get; set; }
	}
}
