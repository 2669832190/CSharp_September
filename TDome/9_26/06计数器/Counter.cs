using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//什么叫线程安全的
//任何时候获取某个变量 得到的值是准确的

//死锁
//持有一个锁同时去获取另一个锁
//但是另一个锁的持有者 也在等待你这个锁释放

//线程等待 线程让步...
namespace _06计数器
{
    //计数器
    internal class Counter
    {
        private int count;

        //创建一个锁
        private static readonly object lockObject = new object();
        //第二个锁
        private static readonly object lockObject2 = new object();

        //让计数器里的数+1
        public void AddCount()
        {
            while (true)
            {
                lock (lockObject)
                {
                    this.count++;
                    Console.WriteLine($"{Thread.CurrentThread.Name}进行了+1操作,加一后的值是:" + this.count);
                    //每增加一次等待半秒
                    lock (lockObject2)
                    {
                        Console.WriteLine("二号锁");
                    }
                }
                Thread.Sleep(500);

            }
        }

        //获取到计数器里的数
        public void getCount()
        {
            while (true)
            {
                lock (lockObject2)
                {
                    Console.WriteLine("计数器的值是:" + this.count);
                    lock (lockObject)
                    {
                        Console.WriteLine("一号锁");
                    }
                }
                //每输出一次计数器的值 等待0.8秒
                Thread.Sleep(800);
            }
        }
    }
}
