using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 车辆信息汇总
    public class Class2
    {
        public  List<Class1> class1s = new List<Class1> { };
       public Class2()
       {
             string[] a = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            Class1 class1 = new Class1((Pin)0, "宝马x7", Program.Chepai(a), 800, false, 0);
            Class1 class2 = new Class1((Pin)1, "奔驰E300", Program.Chepai(a), 300, false, 0);
            Class1 class3 = new Class1((Pin)3, "奥迪A8", Program.Chepai(a), 700, false, 0);
            class1s.Add(class1);
            class1s.Add(class2);
            class1s.Add(class3);
        }
        // 添加
        public void TIan()
        {
            b:
            Console.WriteLine("请输入您要添加的车辆信息 品牌");
            // 品牌
            string a = Console.ReadLine();
            int c = 0;
            switch (a)
            {
                case "宝马":
                    c = 0;
                    break;
                case "奔驰":
                    c = 1;
                    break;
                case "大众":
                    c = 2;
                    break;
                case "奥迪":
                    c = 3;
                    break;
                case "丰田":
                    c = 4;
                    break;
                default:
                    goto b;
            }
            Console.WriteLine("请输入您要添加的车辆信息 型号");
            //型号
            string a1 = Console.ReadLine();
            Console.WriteLine("请输入您要添加的车辆信息 车牌号");
            //车牌号
            string a2 = Console.ReadLine();
            Console.WriteLine("请输入您要添加的车辆信息 租金");
            //租金
            double a3 = Convert.ToDouble(Console.ReadLine());
            prop:
            Console.WriteLine("请输入您要添加的车辆信息 是否租出");
            //是否租出
            string a4 = Console.ReadLine();
            bool d = true;
            if (a4 == "否")
            {
                d = false;
            }
            else if (a4 == "是")
            {
                d = true;
            }
            else
            {
                Console.WriteLine("请重新输入");
                goto prop;
            }
            Console.WriteLine("请输入您要添加的车辆信息 租借天数");
            //租借天数
            int a5 = Convert.ToInt32(Console.ReadLine());
            Class1 class1 = new Class1((Pin)c, a1, a2, a3, d, a5);
            class1s.Add(class1);
            Xun(class1s);
        }
        // 打印车辆信息
        public static void Xun(List<Class1> class1s)
        {
            foreach (var item in class1s)
            {
                Console.Write(item.Pin + " ");
                Console.Write(item.Che + " ");
                Console.Write(item.Hao + " ");
                Console.Write(item.Zujin + " ");
                Console.Write(item.Tf + " ");
                Console.Write(item.Tian + " ");
                Console.WriteLine();
            }
        }
        // 删除
        public void Shanchu()
        {
            Console.WriteLine("请输入要删除的车牌号");
            string a = Console.ReadLine();
            for (int i = 0; i < class1s.Count; i++)
            {
                if (class1s[i].Hao==a)
                {
                    class1s.RemoveAt(i);
                }
            }
            Xun(class1s);
        }
        // 租车
        public void Zuche()
        {
            Xun(class1s);
            Console.WriteLine("请输入要租的车牌号和要租的天数");
            string a = Console.ReadLine();
            int b =Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < class1s.Count; i++)
            {
                if (class1s[i].Hao==a&&class1s[i].Tf==false)
                {
                    Console.WriteLine($"这辆车没有被租出去,租金一天{class1s[i].Zujin}元,一共是{class1s[i].Zujin*b}元");
                    class1s[i].Tf = true;
                    class1s[i].Tian = b;
                    return;
                }
            }
            Console.WriteLine("车牌号不对或该车被租出");
        }
        // 还车
        public void Huanche()
        {
            Xun(class1s);
            Console.WriteLine("请输入要归还的车牌号和实际租借天数");
            string a = Console.ReadLine();
            int b = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < class1s.Count; i++)
            {
                if (class1s[i].Hao == a && class1s[i].Tf == true)
                {
                    if (class1s[i].Tian>b)
                    {
                        Console.WriteLine($"实际租借天数少于规定租借天数,要退还{(class1s[i].Tian-b)* class1s[i].Zujin}元");
                        class1s[i].Tf = false;
                        class1s[i].Tian = 0;
                        return;
                    }
                    else if(class1s[i].Tian < b)
                    {
                        Console.WriteLine($"实际租借天数大于规定租借天数,要补还{(class1s[i].Tian - b) * (class1s[i].Zujin*2)}元");
                        class1s[i].Tf = false;
                        class1s[i].Tian = 0;
                        return;
                    }
                    else
                    {
                        class1s[i].Tf = false;
                        class1s[i].Tian = 0;
                        Console.WriteLine("实际租借天数等于规定租借天数");
                        return;
                    }
                }
            }
            Console.WriteLine("车牌号不对");
        }


    }
}
