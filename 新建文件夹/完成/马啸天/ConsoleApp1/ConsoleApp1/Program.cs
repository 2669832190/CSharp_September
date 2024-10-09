using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Class2 class2 = new Class2();
            Class2.Xun(class2.class1s);
            Console.WriteLine("请选择您要办理的业务（通过输入数字选择以下的各项内容）: 1.添加汽车 2.删除汽车 3.租车汽车 4:还车 5:退出");
            while (true)
            {
                int c = Convert.ToInt32( Console.ReadLine());
                if (c==1)
                {
                    class2.TIan();
                    Console.WriteLine("请选择您要办理的业务（通过输入数字选择以下的各项内容）: 1.添加汽车 2.删除汽车 3.租车汽车 4:还车 5:退出");
                }
                else if (c==2)
                {
                    class2.Shanchu();
                    Console.WriteLine("请选择您要办理的业务（通过输入数字选择以下的各项内容）: 1.添加汽车 2.删除汽车 3.租车汽车 4:还车 5:退出");
                }
                else if (c == 3)
                {
                    class2.Zuche();
                    Console.WriteLine("请选择您要办理的业务（通过输入数字选择以下的各项内容）: 1.添加汽车 2.删除汽车 3.租车汽车 4:还车 5:退出");
                }
                else if (c == 4)
                {
                    class2.Huanche();
                    Console.WriteLine("请选择您要办理的业务（通过输入数字选择以下的各项内容）: 1.添加汽车 2.删除汽车 3.租车汽车 4:还车 5:退出");
                }else if (c == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("输入错误，请重新输入");
                }
            }






            Console.ReadKey();
        }
        // 随机八位车牌
        public static string Chepai(string[] a)
        {
            Thread.Sleep(500);
            string b = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                b += a[random.Next(0, a.Length)];
            }
            return b;
        }
        // 输入全部车辆信息
        
        // 

    }
   
   
     




}
