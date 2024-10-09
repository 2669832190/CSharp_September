using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public enum Brand
    {
        奥迪,
        奔驰,
        宝马,
        本田,
        比亚迪,
    }
    public class Car
    {
        public Brand Brand { get; set; }
        //品牌
        public string Model { get; set; }
        //车型 
        public string Number { get; set; }
        //车牌号  8位
        public double DayMoney { get; set; }
        //每日租金
        public bool RentOut { get; set; } = false;
        //是否租借
        public int RentDays { get; set; } = 0;
        //租赁天数

        public Car(Brand brand, string model, double dayMoney)
        {
            Brand = brand;
            Model = model;
            DayMoney = dayMoney;
            char[] css = new char[8];
            string Ku = "ABCDEFGHIJKLMNOPQRSTUWVXYZ0123456789";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                System.Threading.Thread.Sleep(1);
                int a = random.Next(36);
                css[i] = Ku[a];
            }
            string number = new string(css);
            Number = number;
        }
    }
}
