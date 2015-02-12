using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter05
{
	/// <summary>
	/// Define the structure returned by the LookupItem custom activity
	/// </summary>
	public class ItemInfo
	{
		public string ItemCode { get; set; }
		public string Description { get; set; }
		public decimal Price { get; set; }
	}
}
