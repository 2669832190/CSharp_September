using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05密封类
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Animal
    {
        public string Name { get; set; }
    }

    //Bee 蜜蜂类
    //sealed 密封类
    //1. 防止继承
    //为什么要防止继承?
    //1. 设计意图:这个类不希望被扩展
    //2. 性能:会得到优化 因为没有子类会重写内部的方法
    //3. 安全性:保护这个类的具体实现不会被改变
    public sealed class Bee : Animal
    {

    }
/*
    public class LittleBee : Bee
    {

    }
*/
}
