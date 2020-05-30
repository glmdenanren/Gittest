using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace homework6
{
   public class OrderService
    {
        List<Order> orders = new List<Order>();

        public void Export()
        {
            
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("Order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orders);
            }
            Console.WriteLine(File.ReadAllText("Order.xml"));
        }

        public void Import(string filepath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream(filepath, FileMode.Open))
            {
                List<Order> orders1 = (List<Order>)xmlSerializer.Deserialize(fs);
                Order[] ol = orders1.ToArray();
                foreach (var item in ol)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void AddOrder(string Name, List<OrderItem> items)
        {
            int n = 0;
            foreach (Order order in orders)
                n++;
            orders.Add(new Order(n, Name, items));
        }

        public void DeleteOrder(int OrderId)
        {
            if (orders[OrderId] == null)
                throw new OrderException("没有此订单");
            orders.Remove(orders[OrderId]);
        }
        //通过订单号查询
        public Order searchByOrderId(int Id)
        {
            var order = orders.Where(or => or.OrderId == Id);
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
            {
                Console.WriteLine("此订单不存在！");
                return null;
            }
            else
            {
                return ods[0];
            }


        }
        //设置订单号
        public void setOrderId(int preOrderId, int OrderId)
        {
            if (searchByOrderId(OrderId) != null)
            {
                Console.WriteLine("此订单号已存在！");
            }
            else
            {
                Order order = searchByOrderId(preOrderId);
                order.OrderId = OrderId;
                Console.WriteLine("更改 " + preOrderId + " 订单的编号为 " + OrderId);
            }
        }

        //设置商品数量
        public void setItemAmount(int Id, int Item, int amount)
        {
            Order order = searchByOrderId(Id);
            order.orderItems[Item].amount = amount;
        }

        //设置商品价格
        public void setItemPrice(int Id, int Item, int ItemPrice)
        {
            Order order = searchByOrderId(Id);
            order.orderItems[Item].price = ItemPrice;
        }

        //设置顾客名称
        public void setConsumerName(int Id, string name)
        {
            Order order = searchByOrderId(Id);
            order.Name = name;
        }
        //通过商品名称查询
        public Order[] searchByItemName(string name)
        {
            var order = orders.Where(or => or.orderItems.Contains(new OrderItem(0, name, 0)))
                                .OrderBy(or => or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
            {
                Console.WriteLine("此订单不存在在！");
                return null;
            }
            else
            {
                foreach (var item in ods)
                {
                    Console.WriteLine(item);

                }
                return ods;
            }

        }
        //通过客户名查询
        public Order[] searchByConsumer(string consumer)
        {
            var order = orders.Where(or => or.Name == consumer)
                                .OrderBy(or => or.TotalPrice());
            Order[] ods = order.ToArray<Order>();
            if (ods.Length == 0)
            {
                Console.WriteLine("此订单不存在！");
                return null;
            }
            else
            {
                foreach (var item in ods)
                {
                    Console.WriteLine(item);
                }
                return ods;
            }
        }


        public void OrderSort()
        {
            orders.Sort();
        }
    }
}