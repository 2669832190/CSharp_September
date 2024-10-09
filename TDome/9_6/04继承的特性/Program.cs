using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04继承的特性
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("鳄鱼",6);
            Reptile reptile = new Reptile("蜥蜴", 3);

            Console.WriteLine(animal.Type);
            Console.WriteLine(reptile.Type);
        }
    }
}
