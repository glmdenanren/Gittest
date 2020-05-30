using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
	class OrderItem
	{
		public double price;
		public string name;
		public int amount;
		public double cost;

		public OrderItem(double price,string name ,int amount)
		{
			this.price = price;
			this.name = name;
			this.amount = amount;
			this.cost = amount * price;  //花费为数量乘单价
		}

		public override string ToString()
		{
			return "name" + name + "/t" + "price" + price + "/t" + "amount" + amount + "/t" + "cost" + cost;
		}

		public override bool Equals(object obj)
		{
			OrderItem orderItem = (OrderItem)obj;
			return orderItem != null && orderItem.name == name && orderItem.price == price && orderItem.amount == amount && orderItem.cost == cost;
		}
	}
}
