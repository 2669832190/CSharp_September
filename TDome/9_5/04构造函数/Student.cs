using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04构造函数
{
    internal class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        //构造函数 当实例化对象的时候(new) 会被调用
        public Student()
        {
            Console.WriteLine("调用了构造函数");
            //年龄默认为18岁
            Age = 18;
        }

        //方法重载 根据传递的参数 自动决定调用哪一个
        public Student(string name, int age)
        {
            Console.WriteLine("调用了带参数的构造函数");
            this.Name = name;
            this.Age = age;
        }
        //当只传入一个名字的时候 年龄默认18岁
        /*
        public Student(string name)
        {
            this.Name = name;
            this.Age = 18;
        }
        */
        //构造函数链
        public Student(string name) : this(name, 18) { }
    }
}
