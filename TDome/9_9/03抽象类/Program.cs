using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03抽象类
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //抽象类无法被实例化
            //Animal animal = new Animal();
            //抽象类可以 new 子类
            Animal animal = new Bird();
        }
    }

    //abstract 抽象
    public abstract class Animal
    {
        //抽象属性不能有初始值
        public abstract int leg { get; set; }
        //抽象方法 不能有方法体 不知道方法体怎么写的时候 就可以定义为抽象方法
        //定义了一个规范 子类必须重写抽象方法
        //抽象方法必须写在抽象类中
        public abstract void Call();

        //抽象类中可以包含非抽象成员
        public void Eat()
        {
            Console.WriteLine("动物吃东西");
        }
    }

    public class Bird : Animal
    {
        public override int leg { get; set; } = 2;
        //子类必须重写父类的抽象方法
        public override void Call()
        {
            Console.WriteLine("布谷布谷");
        }

    }
}
