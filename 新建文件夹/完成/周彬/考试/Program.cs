using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    internal class Program
    {
        static Carshop carshop = new Carshop();
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到车行");
            carshop.che();
            Console.WriteLine("1.借车 2.退出");
            int Jieshou = int.Parse(Console.ReadLine());
            switch (Jieshou)
            {
                case 1:
                    JieChe();
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("输入有误");
                    break;
            }
            
        }
        static void JieChe()
        {
            Console.WriteLine("请输入车名:");
            string Carname = Console.ReadLine();
            Console.WriteLine("请输入天数:");
            int day = Convert.ToInt32(Console.ReadLine());

            (bool success, double money) = carshop.JieChe(Carname, day);
            if (success)
            {
                
                Console.WriteLine($"借车成功需要：{money}元");
            }
            else
            {
                Console.WriteLine("车已被借出");
            }
        }
    }
}
