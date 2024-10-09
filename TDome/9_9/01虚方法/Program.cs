using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01虚方法
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Leader leader = new Leader();
            clock.Daka();
            leader.Daka();

            Clock clock1 = new Leader();
            clock1.Daka();
            //Clock 父类
            //Principal 子类
            Clock clock2 = new Principal();
            clock2.Daka();
        }
    }

    public class Clock
    {
        //虚方法
        //1. 可以被重写
        //2. 提供了一个默认实现 子类继承之后 可以有自己的实现 也可以使用父类提供的默认实现
        public virtual void Daka()
        {
            Console.WriteLine("员工打卡时间 9点");
        }
    }

    //这个领导10点打卡
    public class Leader : Clock
    {
        //对虚方法进行重写
        public override void Daka()
        {
            Console.WriteLine("领导打卡 10点");
        }
    }

    public class Principal : Clock
    {
        //隐藏父类继承来的方法
        public new void Daka()
        {
            Console.WriteLine("校长不打卡");
        }
    }
}
