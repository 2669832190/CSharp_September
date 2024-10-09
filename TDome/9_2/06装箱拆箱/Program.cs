using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06装箱拆箱
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //object 是所有数据类型的基类(父类)
            //把数据存放到object里 叫做装箱
            object obj1 = 10;
            object obj2 = 2.5;
            object obj3 = "abc";
            //把数据从object类型里转换为他们对应的类型 叫做拆箱
            int a = (int)obj1;
            double b = (double)obj2;
            string s = (string)obj3;
        }
    }
}
