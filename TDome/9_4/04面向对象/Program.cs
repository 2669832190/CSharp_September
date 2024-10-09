using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04面向对象
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //什么叫面向对象?  面向过程
            //面向过程:维护性差 扩展性差 灵活性差
            //面向对象是一种思路

            //类是需要new的 因为他是引用类型
            Student stu1 = new Student();
            //结构体是值类型 不需要new
            //int i = new int();
            //double d = new double();

            stu1._name = "张三";
            stu1._gender = "男";
            stu1._age = 20;
            stu1.Eat();
            //类和对象是什么区别?
            //类相当于模板
            //对象相当于通过模板创建出的具体的实例
            Student stu2 = new Student();
            stu2._name = "李四";
            stu2.Eat();
        }
    }

    //class 类
    public class Student
    {
        public string _name;
        public string _gender;
        public int _age;

        public void Eat()
        {
            Console.WriteLine("还有10分钟才放学,人已经冲到食堂了");
        }
    }
}
