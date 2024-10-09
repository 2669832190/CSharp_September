using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02静态
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Student.professionalName = "计算机专业";
            //Console.WriteLine(Student.professionalName);
            

            Student student = new Student();
            student.Name = "张三";

            //静态方法 通过类名.方法名调用
            Student.jingTai();
            //非静态方法 通过实例对象名称.方法名调用
            student.feiJingTai();
        }
    }
    public class Student
    {
        public string Name { get; set; }

        //1. 不属于实例化的对象 而是属于类
        //调用的时候 通过类名.属性名调用
        //2. 静态的变量，方法 在程序运行时，就会被创建
        public static string professionalName { get; set; }

        public static void jingTai()
        {
            Console.WriteLine("这是一个静态方法");
            Console.WriteLine("在静态方法里输出专业名称:" + Student.professionalName);
            //静态方法中 只能调用静态属性
            //Console.WriteLine("在静态方法里输出名字:"+Student.Name);
        }

        public void feiJingTai()
        {
            Console.WriteLine("这是一个非静态方法");
            Console.WriteLine("在非静态方法里输出专业名称:" + Student.professionalName);
            //this 这个对象本身
            //非静态方法里 可以调用静态和非静态属性
            Console.WriteLine("在非静态方法里输出名字:" + this.Name);
        }
    }
}
