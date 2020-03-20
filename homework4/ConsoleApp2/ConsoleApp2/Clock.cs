using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   
    public delegate void ClockHandler(object sender);
    class Clock
    {
        public event ClockHandler OnClock;

        public void onClock()
        {

            Console.WriteLine($"时钟启动");
            //打开闹钟
            OnClock(this);
        }

    }
}
