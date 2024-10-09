using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03字典练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //菜单 通过字典保存菜单信息 有菜名和价格
            //1. 添加新菜 输入菜名和价格 然后添加到菜单里    (如果输入的菜名已经重复了 会发生什么?怎么解决?)
            //2. 输出价格小于20的所有菜的菜名和价格
            //3. 涨价 输入菜名和涨多少钱 给对应的菜涨价
            Dictionary<string, int> caiDan = new Dictionary<string, int>()
            {
                {"毛蛋",1 },
                {"拍黄瓜",2 },
                {"水煮白菜",20 }
            };

            Console.WriteLine("请输入一个菜名:");
            string name = Console.ReadLine();
            Console.WriteLine("请输入一个价格:");
            int m = Convert.ToInt32(Console.ReadLine());
            //如果已经包含这个名字的键
            if (caiDan.ContainsKey(name))
            {
                Console.WriteLine("已经有这个菜了");
            }
            else
            {
                caiDan.Add(name, m);
            }

            //2. 输出20块以下的菜
            foreach (var s in caiDan)
            {
                if (s.Value < 20)
                {
                    Console.WriteLine("菜名是:" + s.Key + ",价格是:" + s.Value);
                }
            }

            //3. 涨价 输入菜名和涨多少钱 给对应的菜涨价
            Console.WriteLine("请输入涨价的菜名:");
            //涨价的菜名
            string PriceIncrease = Console.ReadLine();
            Console.WriteLine("请输入涨价的价格:");
            //涨的价格
            int PIM = Convert.ToInt32(Console.ReadLine());
            //先判断有没有这个菜
            if (caiDan.ContainsKey(PriceIncrease))
            {
                //涨价
                caiDan[PriceIncrease] += PIM;
            }

            foreach (var s in caiDan)
            {
                Console.WriteLine("涨价后菜名是:" + s.Key + ",价格是:" + s.Value);
            }
        }
    }
}
