using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    public enum Brand
    {
        奔驰,
        宝马,
        大众,
        五菱,
        长城,
        丰田
    }
    public class Car
    {
        public Brand BrandName { get; set; }
        public string Model { get; set; }
        public string LicensePlate {  get; set; }
        public double DailyPrice { get; set; }
        public bool IsRent {  get; set; }
        public int RentDays { get; set; }

        public Car(Brand brandName, string model, string licensePlate, double dailyPrice, bool isRent, int rentDays)
        {
            BrandName = brandName;
            Model = model;
            LicensePlate = licensePlate;
            DailyPrice = dailyPrice;
            IsRent = isRent;
            RentDays = rentDays;
        }
    }
}
