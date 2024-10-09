using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态类
{
    public static class Dog
    {
        //1. 静态类中只能有静态变量 和 静态方法
        public static string Name = "二哈";

        public static void printName()
        {
            Console.WriteLine(Name);
        }
    }
}
