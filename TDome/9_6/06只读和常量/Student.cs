using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06只读和常量
{
    public class Student
    {
        public string Name { get; set; }
        //只读的年龄
        public int Age { get; } = 10;
        //只读
        public readonly int Height;
        //静态只读属性
        public static readonly int Weight;
        //常量属性 不能修改 需要初始值 自动为静态属性
        public const string Gender = "男";

        //静态构造函数 不能有访问修饰符
        //第一次 实例化对象的时候 被调用(只会调用一次)
        static Student()
        {
            Console.WriteLine("静态构造函数被调用了");
            //静态构造函数可以修改静态只读属性
            Weight = 100;
            //常量不能被修改值
            //Gender = "女";
        }

        //构造函数 new 的时候被调用
        public Student(int Height)
        {
            this.Height = Height;
            //静态方法才能调用静态方法和静态属性
            //this.Weight = Weight;
        }


        public void SetHeight(int Height)
        {
            //只读属性不能赋值
            //this.Height = Height;
            //Age = Height;
        }
    }
}
