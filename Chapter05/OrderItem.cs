using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter04_OrderProcess
{
	public class OrderItem
	{
		public int OrderItemId { get; set; }
		public int Quantity { get; set; }
		public string ItemCode { get; set; }
		public string Description { get; set; }
	}
}
