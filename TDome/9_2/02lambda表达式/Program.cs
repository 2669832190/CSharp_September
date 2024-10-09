using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //可以理解为函数的代理
            Action act = T1;
            act();

            //尖括号里写的是 将要代理的方法的参数
            Action<int> act2 = T2;
            act2(10);

            //有参数有返回值的时候 所有Func 尖括号里先依次填入参数类型 最后填入返回值类型
            Func<int, int> fun1 = T3;
            int x = fun1(20);
            Console.WriteLine(x);
        }

        public static void T1()
        {
            Console.WriteLine("abcd");
        }

        public static void T2(int x)
        {
            Console.WriteLine("x的值是:" + x);
        }

        public static int T3(int x)
        {
            Console.WriteLine("x的值是:" + x);
            return x;
        }
    }
}
