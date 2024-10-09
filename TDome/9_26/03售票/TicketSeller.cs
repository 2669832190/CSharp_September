using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _03售票
{
    internal class TicketSeller
    {
        //车票数量
        private int ticketNum;
        //线程锁
        private readonly object lockObject = new object();

        public TicketSeller(int number)
        {
            this.ticketNum = number;
        }

        public void SellTicket()
        {
            while (true)
            {
                //加锁
                lock (lockObject)
                {
                    if (this.ticketNum > 0)
                    {
                        Console.WriteLine($"{Thread.CurrentThread.Name}卖出了一张票,卖出的是第{ticketNum}张,剩余{ticketNum - 1}张票");
                        ticketNum--;
                    }
                    else
                    {
                        Console.WriteLine("票已卖完");
                        break;
                    }
                }
            }
        }
    }
}
