using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Firm firm = new Firm();
            while (true)
            {
                Console.WriteLine("请选择要办的业务（添加汽车信息：1，删除汽车信息：2，租车：3，还车：4）");
                try
                {
                    int x = int.Parse(Console.ReadLine());
                    switch (x)
                    {
                        case 1:
                            firm.Append();
                            break;
                        case 2:
                            firm.Delete();
                            break;
                        case 3:
                            firm.Carrental();
                            break;
                        case 4:
                            firm.Returnthecar();
                            break;
                        default:
                            Console.WriteLine("输入信息有误，请重新输入");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("输入格式不正确，请重新输入");
                }

            }
        }

    }
    public enum Brand
    {
        奔驰 = 1,
        宝马,
        大众,
        五菱,
        长城,
        丰田
    }
    public class Message
    {
        //品牌
        public Brand brand { get; set; }
        //车型
        public string VehicleType { get; set; }
        //车牌号
        public string LicensePlateNumber { get; set; }
        //每日租金
        public double Rent { get; set; }
        //是否已租出
        public bool RentOrNot { get; set; } = false;
        //租借天数
        public int Day { get; set; } = 0;
    }
    public class Firm
    {
        List<Message> list = new List<Message>();
        public Firm()
        {
            Message mes1 = new Message() { brand = Brand.宝马, VehicleType = Brand.宝马 + "X7", LicensePlateNumber = "豫AS27485", Rent = 300 };
            Message mes2 = new Message() { brand = Brand.宝马, VehicleType = Brand.宝马 + "X6", LicensePlateNumber = "豫QT68257", Rent = 200 };
            Message mes3 = new Message() { brand = Brand.奔驰, VehicleType = Brand.奔驰 + "300", LicensePlateNumber = "豫QS2507", Rent = 250 };
            list.Add(mes1);
            list.Add(mes2);
            list.Add(mes3);
        }
        //遍历信息
        public void G()
        {
            foreach (var m in list)
            {
                Console.WriteLine("品牌：" + m.brand + "，车型：" + m.VehicleType + "，车牌号：" + m.LicensePlateNumber + "，每日租聘价格：" + m.Rent + "，是否被租聘（是：true，否:false）：" + m.RentOrNot + "，被租聘天数：" + m.Day);
            }
        }
        //添加汽车
        public void Append()
        {
            Message mes4 = new Message();
            Console.WriteLine("请选择输入的车辆品牌（奔驰：1，宝马：2，大众：3，五菱:4，长城：5，丰田：6）");
        gert:
            try
            {
                int x = int.Parse(Console.ReadLine());
                switch (x)
                {
                    case 1:
                        mes4.brand = Brand.奔驰;
                        break;
                    case 2:
                        mes4.brand = Brand.宝马;
                        break;
                    case 3:
                        mes4.brand = Brand.大众;
                        break;
                    case 4:
                        mes4.brand = Brand.五菱;
                        break;
                    case 5:
                        mes4.brand = Brand.长城;
                        break;
                    case 6:
                        mes4.brand = Brand.丰田;
                        break;
                    default:
                        Console.WriteLine("本公司没有该汽车品牌，请重新选择");
                        goto gert;
                }
            }
            catch
            {
                Console.WriteLine("输入的格式不正确，请重新输入");
                goto gert;
            }
            Console.WriteLine("请输入车的型号");
            mes4.VehicleType = mes4.brand + Console.ReadLine();
            Console.WriteLine("请输入车牌号");
        chepai:
            string y = Console.ReadLine();
            if (y.Length == 8)
            {
                mes4.LicensePlateNumber = y;
            }
            else
            {
                Console.WriteLine("输入的车牌号格式不正确，请重新输入");
                goto chepai;
            }
            Console.WriteLine("请输入每日租金（单位：元）");
        jine:
            try
            {
                double z = double.Parse(Console.ReadLine());
                mes4.Rent = z;
            }
            catch
            {
                Console.WriteLine("输入的金额格式不对，请重新输入");
                goto jine;
            }
            list.Add(mes4);
        }
        //删除汽车
        public void Delete()
        {
            Console.WriteLine("输入汽车的车牌号");
            string x = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].LicensePlateNumber == x)
                {
                    list.RemoveAt(i);
                    Console.WriteLine("已删除该车辆信息");
                    return;
                }
            }
            Console.WriteLine("没有该车辆信息，删除失败");
        }
        //租车
        public void Carrental()
        {
            G();
            int y;
            Console.WriteLine("请输入想要租聘车辆的车牌号");
            string x = Console.ReadLine();
            Console.WriteLine("输入想要租聘几天");
        carr:
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的时间格式不正确，请重新输入");
                goto carr;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].LicensePlateNumber == x)
                {
                    if (list[i].RentOrNot)
                    {
                        Console.WriteLine("该车辆已被借出");
                        return;
                    }
                    else
                    {
                        list[i].RentOrNot = true;
                        list[i].Day = y;
                        Console.WriteLine($"该车辆租借{y}天,应支付{list[i].Rent * y}");
                        return;
                    }
                }
            }
            Console.WriteLine("未找到该车辆");
            return;
        }
        //还车
        public void Returnthecar()
        {
            G();
            int y;
            Console.WriteLine("请输入租聘车辆的车牌号");
            string x = Console.ReadLine();
            Console.WriteLine("输入实际租聘多少天");
        carr:
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入的时间格式不正确，请重新输入");
                goto carr;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].LicensePlateNumber == x)
                {
                    int z = y - list[i].Day;
                    if (z == 0)
                    {
                        Console.WriteLine("车辆已归还");
                    }
                    else if (z < 0)
                    {
                        Console.WriteLine($"应退还{list[i].Rent * Math.Abs(z)}元");
                    }
                    else
                    {
                        Console.WriteLine($"应补足{list[i].Rent * z * 2}元");
                    }
                    list[i].Day = 0;
                    return;
                }
            }
            Console.WriteLine("未找到该汽车信息");
        }






    }
}
