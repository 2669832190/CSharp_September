using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01只读只写
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 只读只写
            Student student = new Student();
            //赋值会调用set方法
            //student.Name = "张三";
            //可以读 因为获取他的值会调用get方法
            Console.WriteLine(student.Name);

            student.Age = 10;
            //只写的 不能获取值 因为需要调用get方法
            //Console.WriteLine(student.Age);
            #endregion

            Dog dog = new Dog();
            Console.WriteLine(dog.Name);
        }

    }
    public class Student
    {
        //默认是私有的
        string _name;

        int _age;

        //只读
        public string Name
        {
            get { return _name; }
        }

        public int Age
        {
            set { _age = value; }
        }
    }

    public class Dog
    {
        //狗的名字 通过给字段赋值 可以给一个默认值
        string _name = "二哈";

        //通过lambda表达式 简化读写属性
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        /*
        int _age;
        public int Age
        {
            get => _age;
            set => _age = value;
        }
        */

        //语法糖 实际在运行时 会自动生成私有的_age字段
        //前提:没有筛选条件
        //同时可以赋初始值
        public int Age { get; set; } = 10;

    }

    //写一个类 表示商品
    //字段:名字 分类 价格
    //分类有初始值:生活用品 不可修改 可以获取
    //价格 1-100
}
