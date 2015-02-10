using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
	public class OutOfStockException : Exception
	{
		public OutOfStockException()
			: base()
		{ }

		public OutOfStockException(string message) : base(message)
		{

		}
	}
}
