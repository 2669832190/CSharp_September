using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04部分类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "张三";
            student.Age = 18;
            student.printInfo();
        }
    }

    //partial 部分类
    //类的一部分 可以通过多个部分 组成一个类
    //类名相同
    public partial class Student
    {
        public string Name { get; set; }
    }

    public partial class Student
    {
        public int Age { get; set; }
    }

    public partial class Student
    {
        public void printInfo()
        {
            Console.WriteLine(Name + " : " + Age);
        }
    }
}
