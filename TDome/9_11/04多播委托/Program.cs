using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04多播委托
{
    //多播 多次播放
    public delegate void Mydelegate();

    internal class Program
    {
        static void Main(string[] args)
        {
            //多播
            Mydelegate myde = T1;
            myde += T2;
            myde += T3;
            myde += T4;
            myde += T5;

            myde -= T2;
            myde -= T4;

            myde();
        }

        static void T1()
        {
            Console.WriteLine("T1 运行了");
        }
        static void T2()
        {
            Console.WriteLine("T2 运行了");
        }
        static void T3()
        {
            Console.WriteLine("T3 运行了");
        }
        static void T4()
        {
            Console.WriteLine("T4 运行了");
        }
        static void T5()
        {
            Console.WriteLine("T5 运行了");
        }
    }
}
