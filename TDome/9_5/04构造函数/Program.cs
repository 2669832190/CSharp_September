using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04构造函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student student = new Student();
            Console.WriteLine("年龄:" + student.Age);

            Student student1 = new Student("张三", 20);
            Console.WriteLine("名字是:" + student1.Name + ",年龄是:" + student1.Age);
            */
            Student student2 = new Student("李四");
            Console.WriteLine("名字是:" + student2.Name + ",年龄是:" + student2.Age);
        }
    }
}
