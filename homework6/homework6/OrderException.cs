using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
	 public class OrderException : Exception
	{    
		private string erroinfo;
		public OrderException(string info) : base(info) { }
	}
}
