using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static CarRental carRental = new CarRental();
        static void Main(string[] args)
        {
        A:
            Console.WriteLine("欢迎来到马家堡子租车店，本店车辆有");
            carRental.Print();
            Console.WriteLine();
            Console.WriteLine("请选择您需要的服务");
            Console.WriteLine("1/录入汽车、2/删除汽车、3/租赁汽车、4/归还汽车");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    carRental.Luru();
                    goto A;
                case 2:
                    carRental.SanChu();
                    goto A;
                case 3:
                    carRental.ZuChe();
                    goto A;
                case 4:
                    carRental.HuanChe();
                    goto A;
                default:
                    Console.WriteLine("输入错误请重来");
                    goto A;


            }
        }
    }
}
