using System;
using System.Collections.Generic;


namespace homework5
{
	class Program
	{
		static void Main(string[] args)
		{
			OrderService service = new OrderService();
			while(true)
			{
				Console.WriteLine("请选择功能：添加订单；删除订单；查找订单；设置订单；退出系统。");
				string mod = Console.ReadLine();
				switch (mod)
                {
                    case "添加订单":
                        List<OrderItem> orderItems = new List<OrderItem>();
                        while (true)
                        {
                            Console.WriteLine("请输入商品名称:");
                            string ItemName = Console.ReadLine();
                            Console.WriteLine("请输入商品数量:");
                            int ItemNumber = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入商品单价:");
                            int ItemPrice = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("请输入客户名:");
                            string ConsumerName = Console.ReadLine();
                            Console.WriteLine("继续购物？：是/否");
                            string flag = Console.ReadLine();
                            if (flag == "是")
                            {
                                orderItems.Add(new OrderItem(ItemPrice, ItemName, ItemNumber));
                            }
                            else
                            {
                                orderItems.Add(new OrderItem(ItemPrice, ItemName, ItemNumber));
                                service.AddOrder(ConsumerName, orderItems);
                                break;
                            }
                        }
                        break;
                    case "删除订单":
                        while (true)
                        {
                            Console.WriteLine("请输入订单号:");
                            int ornum = Int32.Parse(Console.ReadLine());
                            service.DeleteOrder(ornum);
                            Console.WriteLine("是否继续删除:是/否");
                            string flag = Console.ReadLine();
                            if (flag == "是")
                                continue;
                            else if (flag == "否")
                                break;
                        }
                        break;
                    case "查找订单":
                        while (true)
                        {
                            Console.WriteLine("请输入查找模式:1.按订单号查找；2.按商品名查找；3.按客户名查找");
                            string mode = Console.ReadLine();
                            if (mode == "1")
                            {
                                Console.WriteLine("请输入订单号！");
                                int Id = Int32.Parse(Console.ReadLine());
                                Console.WriteLine(service.searchByOrderId(Id));
                            }
                            else if (mode == "2")
                            {
                                Console.WriteLine("请输入商品名！");
                                string name = Console.ReadLine();
                                Console.WriteLine(service.searchByItemName(name));
                            }
                            else if (mode == "3")
                            {
                                Console.WriteLine("请输入客户名！");
                                string name = Console.ReadLine();
                                Console.WriteLine(service.searchByConsumer(name));

                                Console.WriteLine("是否继续查找:是/否");
                                string flag = Console.ReadLine();
                                if (flag == "是")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }
                        break;
                    case "设置订单":
                        while (true)
                        {
                            while (true)
                            {
                                Console.WriteLine("请输入订单号！");
                                int preOrderId = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("请输入修改后的订单号！");
                                int OrderId = Int32.Parse(Console.ReadLine());
                                service.setOrderId(preOrderId, OrderId);
                                Console.WriteLine("是否继续修改:是/否");
                                string flag = Console.ReadLine();
                                if (flag == "是")
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            break;
                 
                        }
           
                        break;
                    case "退出系统":
                        break;
                    default: Console.WriteLine("无此功能"); break;
                }
            }
        }
    }
}