using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05私有字段
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student();
            stu1._name = "张三";
            //不可以访问私有字段
            //stu1._age
            stu1.SelfIntroduction();

            Student stu2 = new Student();
            stu2._name = "李四";
            stu2.SetAge(18);

            stu2.SelfIntroduction();

        }
    }

    public class Student
    {
        public string _name;
        //私有的
        private int _age;

        public void SelfIntroduction()
        {
            Console.WriteLine("我的名字是:" + _name + ",年龄是:" + _age);
        }

        //修改私有的字段
        public void SetAge(int age)
        {
            _age = age;
        }
    }
}
