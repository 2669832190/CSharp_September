using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 租车
{
    internal class vehicleRental
    {
        public List<Car>cars=new List<Car>();
        public vehicleRental()
        {
            Car car1 = new Car() { Brand = CarBrand.奔驰, Model = "C200", Lic_Num = "京A12345", DailyRent = 200 };
            Car car2 = new Car() { Brand = CarBrand.宝马, Model = "X5", Lic_Num = "京B67890", DailyRent = 360 };
            Car car3 = new Car() { Brand = CarBrand.奥迪, Model = "A8", Lic_Num = "京C34567", DailyRent = 400 };
            cars.Add(car1);
            cars.Add(car2);
            cars.Add(car3);
        }
        public void Print()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"品牌{car.Brand},型号{car.Model},车牌号{car.Lic_Num},租金{car.DailyRent}");
            }
        }
        //租车
        public double Rentar(string model, int rentdays)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Model == model&& !cars[i].IsRented)
                {
                    double rent = rentdays * cars[i].DailyRent;

                    cars[i].IsRented = true;
                    cars[i].RentDays = rentdays;
                    return rent;
                }
            }
            return 0;
        }
        //还车
        public double ReturnCar(string lic_num, int rentdays)
        {
            Print();
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Lic_Num == lic_num && cars[i].IsRented)
                {
                    if (rentdays < cars[i].RentDays)
                    {
                        double rent = cars[i].RentDays-rentdays * cars[i].DailyRent;
                        cars[i].IsRented = false;
                        cars[i].RentDays = 0;
                        return rent;
                    }
                    if(rentdays > cars[i].RentDays)
                    {
                        double rent = rentdays-cars[i].RentDays * cars[i].DailyRent;
                        cars[i].IsRented = false;
                        cars[i].RentDays = 0;
                        return rent;
                    }
                }
            }
            return 0;
        }
    }
}
