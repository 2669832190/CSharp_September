using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //创建一个超市
            Supermarket supermarket = new Supermarket();
            //创建商品
            Commodity commodity1 = new Commodity() { ID = 1, Name = "牙膏", Price = 888 };
            Commodity commodity2 = new Commodity() { ID = 2, Name = "西瓜", Price = 8888 };
            Commodity commodity3 = new Commodity() { ID = 3, Name = "蓝球", Price = 25 };
            //商品 进货
            supermarket.AddCommodity(commodity1);
            supermarket.AddCommodity(commodity2);
            supermarket.AddCommodity(commodity3);
            //出货
            supermarket.RemoveCommodity(2);
            //收银
            Console.WriteLine("请输入一个商品ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入数量:");
            int num = Convert.ToInt32(Console.ReadLine());
            //计算总价格
            double TotalPrice = supermarket.Cashier(id, num);
            Console.WriteLine("总价格是:" + TotalPrice);
        }
    }
}
