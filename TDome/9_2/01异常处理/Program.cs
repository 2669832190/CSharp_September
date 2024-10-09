using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01异常处理
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");

            //try 用来捕获异常 {}里填写可能发生异常的代码
            try
            {
                //当一个异常发生时，会终止程序的运行，导致之后的代码都无法运行
                int num = int.Parse(Console.ReadLine());
                int a = 10 / num;
                Console.WriteLine("a的值是:" + a);
            }
            //()里是这个catch处理的异常
            catch (FormatException e)
            {
                Console.WriteLine("发生了格式不正确异常");
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("发生了异常！尝试除以0！");
            }


            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            Console.WriteLine("我是正常运行的代码");
            */


            try
            {
                int num = int.Parse(Console.ReadLine());
                int a = 10 / num;
                Console.WriteLine("a的值是:" + a);
            }
            //Exception是所有异常的基类(父类)
            //如果要捕获所有异常 catch后面的小括号也可以不写
            catch (Exception e)
            {
                Console.WriteLine("发生了异常");
                
            }
        }
    }
}
