using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07接口特性
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    //爬行动物的规范
    public interface Reptile
    {
        int leg { get; set; }
        void Climb();
    }

    //飞行动物
    public interface FlyAnimals
    {
        void fly();
    }

    //哺乳动物
    public interface Mammal
    {
        void DrinkMilk();
    }

    //动物类
    public class Animal
    {
        public void move()
        {
            Console.WriteLine("动物可以动");
        }
    }

    //昆虫
    public class Insect
    {
        //触角
        public int antenna { get; set; }
    }

    //接口可以实现多个
    //类只能继承一个
    public class Cicada : Animal, Reptile, FlyAnimals, Mammal
    {
        public int leg { get; set; }
        public void Climb()
        {
            Console.WriteLine("知了在地上爬行");
        }
        public void fly()
        {
            Console.WriteLine("知了在天上飞");
        }
        public void DrinkMilk()
        {
            Console.WriteLine("知了在喝树脂");
        }
    }
}