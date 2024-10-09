using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    internal class Program
    {
        static CarList carList = new CarList();
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用汽车租赁系统");
            while (true)
            {
                Console.WriteLine("请输入要进行的操作：1.添加汽车2.删除汽车3.租车4.还车5.退出系统");
                int inputNum;
                //判断输入的内容是否为数字
                while (true)
                {
                    try
                    {
                        inputNum = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("输入错误，请输入数字。");
                    }
                }
                switch (inputNum)
                {
                    case 1:
                        AddCar();
                        break;
                    case 2:
                        DeleteCar();
                        break;
                    case 3:
                        carList.Print();
                        CarRental();
                        break;
                    case 4:
                        carList.Print();
                        ReturnCar();
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("输入的数字有误，请重新输入！");
                        break;
                }
            }
        }
        //添加汽车
        static void AddCar()
        {
        bbb:
            Console.Write("请输入汽车品牌:");
            string strBrand = Console.ReadLine();
            Brand brand;
            if (Enum.TryParse(strBrand, out brand))
            {
                //Console.WriteLine($"转换后的枚举值为：{brand}");
            }
            else
            {
                Console.WriteLine("无法转换为有效的枚举值。");
                goto bbb;
            }

            Console.Write("请输入汽车车型:");
            string model = Console.ReadLine();

        aaa:
            Console.Write("请输入车牌号:");
            string num = Console.ReadLine();
            if (num.Length == 8)
            {
                string licensePlate = num;
            }
            else
            {
                Console.WriteLine("输入的车牌号不是8位字符串，请重新输入");
                goto aaa;
            }

            Console.Write("请输入每日租金:");
            int dailyPrice = Convert.ToInt32(Console.ReadLine());

            carList.AddCar(brand, model, num, dailyPrice);
            Console.WriteLine("添加汽车成功!");
        }
        //删除汽车
        static void DeleteCar()
        {
            Console.Write("请输入要删除汽车的车牌号:");
            string str = Console.ReadLine();
            carList.DeleteCar(str);
            Console.WriteLine("删除汽车成功!");
        }
        //租车
        static void CarRental()
        {
            Console.Write("请输入想租的车辆的车牌号:");
            string str = Console.ReadLine();
            Console.Write("请输入租借天数:");
            int num = Convert.ToInt32(Console.ReadLine());
            double price = carList.CarRental(str, num);
            Console.WriteLine("租车所需付的金额是:"+price);
        }
        //还车
        static void ReturnCar()
        {
            Console.Write("请输入归还的车辆的车牌号:");
            string str = Console.ReadLine();
            Console.Write("请输入实际租借天数:");
            int days = Convert.ToInt32(Console.ReadLine());
            carList.ReturnCar(str, days);
        }
    }
}
