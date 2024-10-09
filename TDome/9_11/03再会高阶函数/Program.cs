using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03再会高阶函数
{
    public delegate void MyAction();
    public delegate T2 MyFunc<T, T2>(T t);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyAction mya = T1;
            Test(mya);

            MyFunc<string, int> myf = T2;
            Test2(T2);
        }

        //参数 action 要的是方法 {没有返回值,没有参数}
        static void Test(MyAction action)
        {
            action();
        }

        //参数 需要符合MyFunc的标签 
        //{第一个T是string,第二个T是int} 参数类型string，返回值是int
        static void Test2(MyFunc<string, int> func)
        {
            int a = func("abcd");
            Console.WriteLine(a);
        }

        static void T1()
        {
            Console.WriteLine("T1运行了");
        }

        //输入一个字符串，返回他的长度
        static int T2(string s)
        {
            return s.Length;
        }
    }
}
