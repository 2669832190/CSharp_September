using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01接口显式实现
{
    public interface Bird
    {
        void Fly();
    }
    public interface WoodpeckerFamily
    {
        void Fly();
    }

    public class Animal
    {
        void Fly() { }
    }

    //啄木鸟
    public class Woodpecker : Animal, Bird, WoodpeckerFamily
    {
        //显式 实现 接口      通过接口名.方法名
        //1. 避免名称冲突
        //2. 只能通过声明接口类型 调用
        //3. 通过同一个类实现不同版本
        void Bird.Fly()
        {
            Console.WriteLine("鸟会飞");
        }

        void WoodpeckerFamily.Fly()
        {
            Console.WriteLine("啄木鸟家族的飞法");
        }

        public void Fly()
        {
            Console.WriteLine("鸟又飞一次");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Woodpecker wood = new Woodpecker();
            wood.Fly();
            //接口 new 类
            Bird bird = new Woodpecker();
            bird.Fly();

            WoodpeckerFamily birdwood = new Woodpecker();
            birdwood.Fly();
        }
    }

}
