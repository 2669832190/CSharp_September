using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06字段_属性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studnet stu1 = new Studnet();
            //私有字段无法访问
            //stu1._name

            //设置Name的值
            stu1.Name = "张三";
            Console.WriteLine(stu1.Name);

            stu1.Age = -10;
            Console.WriteLine(stu1.Age);
        }
    }

    //封装
    //封闭底层逻辑 只给用户访问 设定好的内容
    public class Studnet
    {
        //字段
        private string _name;
        private int _age;

        //属性
        /*
         属性 没有保存值
         相当于中间商 字段的保镖
         当属性被访问的时候 会触发get方法 我们可以通过return字段拿到对应的值
         当属性被修改的时候 会触发set方法 我们可以在set方法里设置字段的值
         */
        public string Name
        {
            get
            {
                Console.WriteLine("触发了 get 方法");
                return _name;
            }
            set
            {
                Console.WriteLine("触发了 set 方法，将值设定为" + value);
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                Console.WriteLine("访问了年龄");
                return _age;
            }
            set
            {
                Console.WriteLine("触发了 set 方法，设置年龄");
                if(value >= 0 && value <= 100)
                {
                    _age = value;
                }
                else
                {
                    _age = 0;
                    Console.WriteLine("输入的年龄不合法，自动设置为0");
                }
            }
        }
    }
}
