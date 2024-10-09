using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student("张三", Gender.男, 20);
            Student stu2 = new Student("李四", 18);

            stu1.SelfIntroduction();
            stu2.SelfIntroduction();
        }
    }
}
