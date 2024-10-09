using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03静态类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //2. 静态类无法被实例化
            //Dog dog = new Dog(); //报错
            Dog.printName();
            Console.WriteLine(Dog.Name);
            */

            Cat cat = new Cat();
            cat.Name = "佩奇";
            cat.printName("乔治");
        }

    }
}
