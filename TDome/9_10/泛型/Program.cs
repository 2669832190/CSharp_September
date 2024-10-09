using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 泛型
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Test<int>(10);
            Test<string>("abc");
            //不填写<>里类型的时候,他会根据传入的参数自动识别类型
            Test('a');
            

            Test<int, string, char>(10,"abc",'a');

            //int数组类型
            var t = Test2<string, char, int>("qwer", 'c', new int[] { 1, 2, 3 });
            foreach(int i in t)
            {
                Console.WriteLine(i);
            }
        }

        //泛型 广泛的类型

        //传入一个参数 然后输出这个值
        //T 类型的名称
        static void Test<T>(T x)
        {
            Console.WriteLine(x);
        }

        //T 表示的是类型 类型不同,类型的名称也就不同
        static void Test<T,T2,T3>(T x,T2 y,T3 z)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }


        static T2[] Test2<T,T1,T2>(T x,T1 y, T2[] z)
        {
            return z;
        }
    }
}
