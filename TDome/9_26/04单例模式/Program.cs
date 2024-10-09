using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04单例模式
{
    internal class Program
    {
        //23种设计模式 之前讲了工厂模式
        //单例模式 只有一个对象
        static void Main(string[] args)
        {
            Config con = Config.GetConfig();
            Config con1 = Config.GetConfig();

            if(con == con1)
            {
                Console.WriteLine("相等");
            }
            else
            {
                Console.WriteLine("不相等");
            }
        }
    }
}
