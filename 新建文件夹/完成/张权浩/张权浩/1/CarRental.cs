using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class CarRental
    {
        private List<Car> list = new List<Car>();
        public CarRental()
        {
            Car car1 = new Car(Brand.奔驰, "E300", 299);
            Car car2 = new Car(Brand.宝马, "X5", 499);
            Car car3 = new Car(Brand.奥迪, "A8", 699);
            list.Add(car1);
            list.Add(car2);
            list.Add(car3);
        }
        public void Print()
        {
            foreach (Car car in list)
            {
                Console.WriteLine("车辆品牌：" + car.Brand + "   具体型号：" + car.Model + "   车牌号：" + car.Number + "   每日租金：" + car.DayMoney);
                if (car.RentOut == false)
                {
                    Console.WriteLine("没有租出");
                }
                else if (car.RentOut == true)
                {
                    Console.WriteLine("已租出，租出天数：" + car.RentDays + "天。");
                }
            }
        }
        public void Luru()
        {
        A:
            Console.WriteLine("请输入车辆品牌/奥迪/奔驰/宝马/本田/比亚迪");
            string a = Console.ReadLine();
            if (a != "奥迪" && a != "奔驰" && a != "宝马" && a != "本田" && a != "比亚迪")
            {
                Console.WriteLine("本店不收该类车型");
                goto A;
            }
            Brand e = (Brand)Enum.Parse(typeof(Brand), a);
            Console.WriteLine("请输入汽车型号");
            string b = Console.ReadLine();
            Console.WriteLine("请输入每日租金");
            double c = double.Parse(Console.ReadLine());
            Car car = new Car(e, b, c);
            list.Add(car);
        }
        public void SanChu()
        {
            Console.WriteLine("请输入车牌号");
            string a = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Number == a)
                {
                    list.RemoveAt(i);
                    Console.WriteLine("删除成功");

                }
            }
        }
        public void ZuChe()
        {
            foreach (Car car in list)
            {
                Console.WriteLine("车辆品牌：" + car.Brand + "   型号：" + car.Model + "   车牌号：" + car.Number + "   每日租金：" + car.DayMoney);
                if (car.RentOut == false)
                {
                    Console.WriteLine("没有租出");
                }
                else if (car.RentOut == true)
                {
                    Console.WriteLine("已租出，租出天数：" + car.RentDays + "天。");
                }
            }
            Console.WriteLine();
            Console.WriteLine("请输入相应的车牌号进行租车");
            string a = Console.ReadLine();
            Console.WriteLine("请输入租车天数");
            int b = int.Parse(Console.ReadLine());
            foreach (Car car in list)
            {
                if (car.Number == a)
                {
                    if (car.RentOut == true)
                    {
                        Console.WriteLine("该车已被租出");
                        Console.WriteLine("租出天数为：" + car.RentDays + "天");
                        break;
                    }
                    else if (car.RentOut == false)
                    {
                        car.RentOut = true;
                        Console.WriteLine("共需租金：" + b * car.DayMoney + "元");
                        car.RentDays = b;
                        break;
                    }
                }
            }
        }
        public void HuanChe()
        {
            foreach (Car car in list)
            {
                Console.WriteLine("车辆品牌：" + car.Brand + "   具体型号：" + car.Model + "   车牌号：" + car.Number + "   每日租金：" + car.DayMoney);
                if (car.RentOut == false)
                {
                    Console.WriteLine("没有租出");
                }
                else if (car.RentOut == true)
                {
                    Console.WriteLine("已租出，租出天数：" + car.RentDays + "天。");
                }
            }
            Console.WriteLine();
            Console.WriteLine("请输入归还车辆的车牌号");
            string a = Console.ReadLine();
            Console.WriteLine("请输入实际租车天数");
            int b = int.Parse(Console.ReadLine());
            foreach (Car car in list)
            {
                if (car.Number == a)
                {
                    if (b <= car.RentDays)
                    {
                        Console.WriteLine("预租车" + car.RentDays + "天，实租车" + b + "天，应退还金额" + (car.RentDays - b) * car.DayMoney + "元");
                    }
                    else if (b > car.RentDays)
                    {
                        Console.WriteLine("预租车" + car.RentDays + "天，实租车" + b + "天，额外需付" + (b - car.RentDays) * car.DayMoney * 2 + "元");
                    }
                }
            }
        }
    }
}
