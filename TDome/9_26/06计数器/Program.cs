using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _06计数器
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter count = new Counter();

            //5个线程负责增加计数器的值
            Thread[] ths = new Thread[5];
            for(int i = 0; i < ths.Length; i++)
            {
                ths[i] = new Thread(count.AddCount);
                //给线程加个名字
                ths[i].Name = "线程" + i;

                ths[i].Start();
            }

            //5个线程输出
            Thread[] ths2 = new Thread[5];
            for(int i = 0;i < ths2.Length; i++)
            {
                ths2[i] = new Thread(count.getCount);

                ths2[i].Start();
            }
        }
    }
}
