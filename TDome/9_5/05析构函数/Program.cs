using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05析构函数
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //有一只红鸵鸟
            Bird bird1 = new Bird(2200,Colour.红);
            //鸟下蛋
            bird1.layEggs();
        }
    }
}
