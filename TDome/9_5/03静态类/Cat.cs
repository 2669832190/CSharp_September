using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态类
{
    public class Cat
    {
        public string Name { get; set; }

        //这个方法的功能是 输入一个名字，修改原来的名字，并打印修改前后的名字
        public void printName(string Name)
        {
            //this 这个对象
            Console.WriteLine("修改前的名字:"+this.Name);
            Console.WriteLine("修改后的名字:"+Name);
            //当前对象的Name = 传递进来的参数Name的值
            this.Name = Name;
        }
    }
}
