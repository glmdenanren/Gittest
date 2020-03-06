using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] flag = new bool[101];
            for (int i = 2; i < 101; i++)
            {
                flag[i] = true;
            }
            int j = 2;
            while(j<=50)
            {
                for(int r = 1; r < 101; r++)
                {
                    if (r % j == 0 && r != j)
                        flag[r]= false;

                }
                j++;
            }
            for (int m = 2; m < 101; m++)
            {
                if (flag[m] == true)
                    Console.WriteLine(m);
            }
        }
    }
}
