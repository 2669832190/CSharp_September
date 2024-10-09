using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02泛型委托
{
    //泛型委托
    //没有返回值 有两个泛型参数
    public delegate void MyDelegate<T>(T x, T y);
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate<int> myDe = T1;
            MyDelegate<string> myDe2 = T2;

            myDe(10, 20);
            myDe2("string", "int");
        }

        static void T1(int x, int y)
        {
            Console.WriteLine("x和y相加的和是:" + (x + y));
        }
        static void T2(string x, string y)
        {
            Console.WriteLine("x和y的长度相加的和是:" + (x.Length + y.Length));
        }
    }


}
