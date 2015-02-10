using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
using System.Collections.Generic;

namespace Chapter04_OrderProcess
{

	class Program
	{
		static void Main(string[] args)
		{
			var myOrder = Program.BuildOrder();

			IDictionary<string, object> input = new Dictionary<string, object>
			{
				{ "OrderInfo", myOrder }
			};
			IDictionary<string, object> output = WorkflowInvoker.Invoke(new OrderWorkflow(), input);

			decimal total = (decimal)output["TotalAmount"];
			Console.WriteLine("Workflow returned {0} for my order total.", total.ToString("C"));

			Console.WriteLine("Press ENTER to exit");
			Console.ReadLine();
		}

		static Order BuildOrder()
		{
			var order = new Order
			{
				OrderId = 1,
				Description = "Need some stuff",
				ShippingMethod = "2ndDay",
				TotalWeight = 100
			};

			// Add some OrderItem objects
			order.Items.Add(new OrderItem
			{
				OrderItemId = 1,
				Quantity = 1,
				ItemCode = "12345",
				Description = "Widget"
			});
			order.Items.Add(new OrderItem
			{
				OrderItemId = 2,
				Quantity = 3,
				ItemCode = "12346",
				Description = "Gadget"
			});
			order.Items.Add(new OrderItem
			{
				OrderItemId = 3,
				Quantity = 2,
				ItemCode = "12347",
				Description = "Super Widget"
			});

			return order;
		}
	}
}
