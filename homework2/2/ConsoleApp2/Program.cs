using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public static void dealArray(int[] num, int Length)
        {

            double Max = -1e9, Min = 1e9;
            double Add = 0; double Averge = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > Max) Max = num[i];
                if (num[i] < Min) Min = num[i];
                Add += num[i];
            }
            Averge = Add / Length;
            Console.WriteLine("此数组的最大值为：" + Max);
            Console.WriteLine("此数组的最小值为：" + Min);
            Console.WriteLine("此数组值的和为：" + Add);
            Console.WriteLine("此数组的平均值为：" + Averge);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入数组长度：");
            String l = Console.ReadLine();
            int n = Int32.Parse(l);
            int[] a = new int[n];
            Console.WriteLine("请输入数组的值：");
            for (int i = 0; i < n; i++)
            {
                String s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
            dealArray(a, n);

        }
    }
}
