using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 租车
{
    internal class Program
    {
        static vehicleRental rental = new vehicleRental();
        static void Main(string[] args)
        {
            //Dictionary<string, double> Model_Price= new Dictionary<string, double>();
            //Model_Price.Add(CarBrand.奥迪, 300);
            //Model_Price.Add("奥迪A6", 300);
            //string[] car_type = new string[0];
            //Dictionary<CarBrand, List<Type>> CarList = new Dictionary<CarBrand, List<Type>>();
            
            Console.WriteLine("欢迎使用租车系统");
            while (true)
            {
                Console.WriteLine("1.添加汽车 2.删除汽车 3.租车 4.还车");

            }
        }
        public void AddCar ()
        {

        }
        public void DeleteCar()
        {

        }
    }
}
