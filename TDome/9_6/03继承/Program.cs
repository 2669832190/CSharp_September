using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03继承
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Monkey monkey = new Monkey();
            monkey.Age = 10;
            monkey.Color = "金色";
            monkey.Weight = 2500;
            //猴子可以吃桃
            monkey.eatPeach();
            //猴子可以吃喝拉撒睡
            monkey.CHLSS();
            //私有的方法和属性 无法被继承
            //monkey.Fly();
            //受保护的 仅类内部和子类内部可调用
            //monkey.Swimming();
        }
    }
}
