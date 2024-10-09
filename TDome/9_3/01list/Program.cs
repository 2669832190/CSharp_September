using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01list
{
    public struct Student
    {
        public string _name;
        public int _age;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //动态数组
            //长度不固定 能够储存任意类型
            //ArrayList list = new ArrayList();

            //长度不固定 只能保存相同的类型
            //不需要装箱拆箱 所以速度更快
            List<string> list = new List<string>();
            list.Add("123");
            list.Add("abc");

            List<int> list2 = new List<int>();
            list2.Add(123);
            list2.Add(456);

            List<Student> list3 = new List<Student>();
            list3.Add(new Student { _name = "张三", _age = 20 });
            //先创建好结构体 再保存
            Student stu1;
            stu1._name = "李四";
            stu1._age = 20;
            list3.Add(stu1);

            //声明的同时进行赋值
            List<char> list4 = new List<char>() { 'a', 'b', 'c', 'd' };
            //list4.Count 长度(这个list里保存的元素的数量)
            Console.WriteLine(list4.Count);
            //访问一个元素
            Console.WriteLine(list4[2]);

            //指定内容删除
            list4.Remove('c');
            //指定索引删除
            list4.RemoveAt(1);
        }
    }
}
