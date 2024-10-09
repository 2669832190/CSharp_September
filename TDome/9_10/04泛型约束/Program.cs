using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04泛型约束
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print<int>(20);
            Print<string>("123");
            Print<char>('a');

            Print2<int>(20);
            Print2<double>(4.5);
            //Print2<string>("abc");

            //Print3<int>(20);
            //Print3<double>(4.5);
            Print3<string>("abc");
        }

        //泛型过于广泛 需要进行约束
        static void Print<T>(T x)
        {
            Console.WriteLine(x);
        }

        //值类型约束 T只能为值类型
        static void Print2<T>(T x) where T : struct
        {
            Console.WriteLine(x);
        }

        //引用类型约束
        static void Print3<T>(T x) where T : class
        {
            Console.WriteLine(x);
        }

        //类 能够进行new()的类型 必须拥有无参构造函数
        static void Print4<T>(T x) where T : new()
        {
            Console.WriteLine(x);
        }

        //只能是指定的类 或者 是其子类
        static void Print5<T>(T x) where T : Animal
        {
            Console.WriteLine(x);
        }

        //只能是指定的接口 或者 实现了该接口的类
        static void Print6<T>(T x) where T : Bird
        {
            Console.WriteLine(x);
        }

        //T的类型 必须是U的类型或者其子类
        static void Print7<T, U>() where T : U
        {

        }
    }

    public class Animal
    {
        
    }
    public interface Bird { }

}
