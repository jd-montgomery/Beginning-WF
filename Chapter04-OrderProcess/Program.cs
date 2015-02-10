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
			return new Order
			{
				OrderId = 1,
				Description = "Need some stuff",
				ShippingMethod = "2ndDay",
				TotalWeight = 100
			};
		}
	}
}
