using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01委托
{
    internal class Program
    {
        //委托 帮别人干活? 代理方法(代替方法运行)
        //delegate 声明委托
        //void MyDelegate()  表示能代理什么样的方法运行
        //我们这个委托 表示 能代理 {没有返回值,没有参数} 的方法
        public delegate void MyDelegate();
        //string MyDelegate2(int x)
        //能代理 {返回值为string,参数为int} 的方法
        public delegate string MyDelegate2(int x);

        static void Main(string[] args)
        {
            //我们上面声明的委托 要作为类型使用
            //new的时候 填入的参数 就是要代理的方法
            MyDelegate my1 = new MyDelegate(T1);
            my1();

            MyDelegate2 my2 = new MyDelegate2(T2);
            string s = my2(10);
            Console.WriteLine(s);

            //使用lambda表达式
            MyDelegate myDe = new MyDelegate(() => Console.WriteLine("lambda表达式创建的没有名字的方法"));
            myDe();

            //还有什么其他方法创建代理?
            //赋值会覆盖掉原来的值
            myDe = T1;
            myDe();
            //还能怎么赋值?
            myDe = delegate () { Console.WriteLine("通过delegate创建的方法"); };
            myDe();

            MyDelegate2 myDe2 = delegate (int x)
            {
                Console.WriteLine("x的值是:" + x);
                return x + "";
            };
            myDe2(20);
        }

        static void T1()
        {
            Console.WriteLine("T1运行了");
        }
        static string T2(int x)
        {
            Console.WriteLine("T2运行了,x的值是:" + x);
            return "" + x;
        }
    }
}
