using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03售票
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //给主线程改名
            Thread.CurrentThread.Name = "主线程Main";

            TicketSeller ts = new TicketSeller(20);

            //需要5个售票员卖票
            Thread[] ths = new Thread[5];

            for(int i = 0; i < ths.Length; i++)
            {
                //让第i个线程卖票
                ths[i] = new Thread(ts.SellTicket);
                //更改线程的名字为线程i
                ths[i].Name = $"线程{i}";
                //开始卖票
                ths[i].Start();
            }
        }
    }
}
