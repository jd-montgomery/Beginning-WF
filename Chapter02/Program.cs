using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Activities;
using System.Activities.Statements;
using System.Activities.Expressions;

namespace Chapter_02
{
	class Program
	{
		static void Main(string[] args)
		{
			WorkflowInvoker.Invoke(Program.CreateWorkflow());
		}

		static Activity CreateWorkflow()
		{
			Variable<int> numberOfBells = new Variable<int>()
			{
				Name = "numberOfBells",
				Default = DateTime.Now.Hour
			};
			var counter = new Variable<int>()
			{
				Name = "counter",
				Default = 1,
			};

			return new Sequence()
			{
				DisplayName = "Main Sequence",
				Variables = { numberOfBells, counter },
				Activities =
				{
					new WriteLine
					{
						DisplayName = "Hello",
						Text = "Hello, World!",
					},
					new If
					{
						DisplayName = "Adjust For PM",
						Condition = ExpressionServices.Convert<bool>(env => numberOfBells.Get(env) > 12),
						Then = new Assign<int>
						{
							DisplayName = "Adjust Bells",
							// level 3
						}
					},
					new While
					{
						DisplayName = "Sound Bell(s)",
						Condition = ExpressionServices.Convert<bool>(env => counter.Get(env) <= numberOfBells.Get(env)),
						Body = new Sequence
						{
							DisplayName = "Sound Bell",
							// level 3
						},
					},
					new WriteLine
					{
						DisplayName = "Display Time",
						Text = "The time is " + DateTime.Now.ToString(),
					},
					new If
					{
						DisplayName = "Greeting",
						Condition = ExpressionServices.Convert<bool>(env => DateTime.Now.Hour >= 18),
						Then = new WriteLine { Text = "Good Evening" },
						Else = new WriteLine { Text = "Good Day" },
					}
				}
			};
		}
	}
}