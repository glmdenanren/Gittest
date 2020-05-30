using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
      public  class Order
	{
		public int OrderId { set; get; }
		public double OrderCost;
		public string Name { set; get; }
		public List<OrderItem> orderItems;//菜单

		//构造方法
		public Order() { }
		public Order(int OrderId, string Name, List<OrderItem> orderItems)
		{
			this.OrderId = OrderId;
			this.Name = Name;
			this.orderItems = orderItems;
		}
		//计算订单的总消费
		public double TotalPrice()
		{
			foreach (var item in orderItems)
			{
				this.OrderCost += item.cost;
			}
			return OrderCost;
		}
		//重新写ToString方法
		public override string ToString()
		{
			return "Order Id:" + OrderId + "/t" + "customer name:" + Name + "/t" + "OrderCost:" + OrderCost;
		}

		//重写Equals方法，判断订单是否重复
		public override bool Equals(object obj)
		{
			Order order = (Order)obj;
			return order != null && order.OrderId == OrderId && order.Name == Name && order.OrderCost == OrderCost;
		}
	}
}
