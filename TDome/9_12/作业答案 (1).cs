using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //T1();
            //T2();
            //T3();
            //T4();
            T5();
        }

        static void T1()
        {
            Console.WriteLine("请输入一个糖果数:");
            //糖果数量
            int candy = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                int leaveBehind = candy / 3;
                Console.WriteLine($"第{i + 1}个小朋友留下了{leaveBehind}个糖果");
                //剩余的分给下一个小朋友的糖果
                candy = candy / 3 * 2;
            }
        }

        static void T2()
        {
            Console.WriteLine("请输入老师有多少饼干:");
            //饼干的数量
            int cookie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入小朋友的数量:");
            //小朋友的数量
            int children = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= children; i++)
            {
                cookie -= i;
            }
            if (cookie >= 0)
            {
                Console.WriteLine($"饼干够分,剩余{cookie}块饼干");
            }
            else
            {
                Console.WriteLine($"饼干不够分,还需要{cookie * -1}块饼干");
            }
        }

        static void T3()
        {
            Console.WriteLine("请输入一个数，表示灯和人的数量:");
            //灯和人的数量
            int lamp = Convert.ToInt32(Console.ReadLine());
            //灯的状态
            bool[] lampState = new bool[lamp];

            //循环人数次，每个人都进行操作
            for (int i = 1; i <= lamp; i++)
            {
                //每个人进行什么操作？每个灯都要判断一遍要不要开关
                for (int j = 1; j <= lampState.Length; j++)
                {
                    //如果灯的序号 % 人的编号 == 0
                    if (j % i == 0)
                    {
                        //当前的灯的状态
                        lampState[j - 1] = !lampState[j - 1];
                    }
                }
            }

            //用来记录开着的灯的总数
            int count = 0;
            //有多少灯是开着的？
            for (int i = 0; i < lampState.Length; i++)
            {
                //如果是true 说明灯是开着的
                if (lampState[i])
                {
                    count++;
                }
            }
            Console.WriteLine($"有{count}灯是开着的");
        }

        static void T4()
        {
            Console.WriteLine("请输入一个字符串:");
            string str = Console.ReadLine();
            //遍历所有的字符
            for (int i = 0; i < str.Length; i++)
            {
                //第一次出现的索引 == 最后一次出现的索引 说明只出现了一次
                if (str.IndexOf(str[i]) == str.LastIndexOf(str[i]))
                {
                    Console.WriteLine($"字符{str[i]}是只出现了一次并且第一次出现的字符");
                    return;
                }
            }
        }

        static void T5()
        {
            Console.WriteLine("请输入开始学习的时分秒:");
            //时分秒
            int H = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入学习了多久:");
            int time = Convert.ToInt32(Console.ReadLine());

            //开始学习的时间
            DateTime dateTime = new DateTime(2024, 9, 13, H, M, S);
            //学习了多久
            dateTime = dateTime.AddSeconds(time);
            Console.WriteLine($"开始休息的时间是{dateTime.ToString("G")}");
        }
    }
}
