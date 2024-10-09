using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06接口
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Animal animal = new Animal();
        }
    }

    //interface 接口
    //定义一个规范 不能用有初始值和方法体
    public interface Animal
    {
        int leg {  get; set; }

        void Eat();
    }

    //实现Animal接口的功能
    public class Elephant : Animal
    {
        public int leg { get; set; } = 4;

        //不需要重写
        public void Eat()
        {
            Console.WriteLine("大象用鼻子抓东西，给嘴吃");
        }
    }

    
}
