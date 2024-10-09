using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06只读和常量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一个Studnet new之前");
            Student student1 = new Student();
            Console.WriteLine("第一个Student new之后 第二个new之前");
            Student student2 = new Student();
            Console.WriteLine("第二个Student new完成了");
            Student student3 = new Student();
            Console.WriteLine("第三个Student new之后");
        }
    }
}
