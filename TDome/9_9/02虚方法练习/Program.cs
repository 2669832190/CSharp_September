using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02虚方法练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Bird bird = new Bird();
            KunKun kunKun = new KunKun();
            //子类类型 new 子类类型
            LaoBa laoBa = new LaoBa();

            //全都是动物吃东西
            animal.Eat();
            bird.Eat();
            kunKun.Eat();
            laoBa.Eat();

            animal.Call();
            bird.Call();
            kunKun.Call();
            laoBa.Call();

            Animal animal1 = new Bird();
            Animal animal2 = new KunKun();
            Animal animal3 = new LaoBa();

            animal1.Eat();
            animal2.Eat();
            animal3.Eat();

            animal1.Call();
            animal2.Call();
            animal3.Call();

            //使用list
            List<Animal> list = new List<Animal>();
            list.Add(animal1);
            list.Add(animal2);
            list.Add(animal3);

            //使用纯数组
            Animal[] animals = new Animal[3] { animal1, animal2, animal3 };
            foreach(Animal anim in animals)
            {
                //如果没有使用虚方法
                /*
                if(anim is Bird)
                {
                    Bird bir = anim as Bird;
                }else if(anim is KunKun)
                {
                    //
                }
                */
                anim.Call();
            }
        }
    }

    //动物类
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("动物吃东西 吭哧吭哧");
        }

        public virtual void Call()
        {
            Console.WriteLine("动物开始叫");
        }
    }

    public class Bird : Animal
    {
        public override void Call()
        {
            Console.WriteLine("布谷布谷");
        }
    }
    public class KunKun : Animal
    {
        public override void Call()
        {
            Console.WriteLine("哎呦 你干嘛");
        }
    }
    public class LaoBa : Animal
    {
        public void Eat()
        {
            Console.WriteLine("老八吃秘制小汉堡");
        }

        public override void Call()
        {
            Console.WriteLine("嗨嗨嗨");
        }
    }
}
