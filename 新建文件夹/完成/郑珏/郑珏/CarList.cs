using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考试
{
    public class CarList
    {
        private List<Car> list = new List<Car>();

        public CarList()
        {
            Car car1 = new Car( Brand.宝马, "X7", "A123456",390, false, 0 );
            Car car2 = new Car(Brand.奔驰, "300", "AB987654", 560, false, 0);
            Car car3 = new Car(Brand.丰田, "威兰达", "12345678", 280, false, 0);
            //添加到list
            list.Add(car1);
            list.Add(car2);
            list.Add(car3);
        }
        //打印汽车信息
        public void Print()
        {
            foreach (var item in list)
            {
                Console.WriteLine($"品牌:{item.BrandName} 车型:{item.Model} 车牌号:{item.LicensePlate} 每日租金:{item.DailyPrice} 是否已租出:{item.IsRent} 租借天数:{item.RentDays}");
            }
        }
        //添加汽车
        public void AddCar(Brand brand,string model,string licensePlate,int dailyPrice)
        {
            Car newCar = new Car(brand,model,licensePlate,dailyPrice,false,0);
            list.Add(newCar);
        }
    
        //删除汽车
        public void DeleteCar(string licensePlate)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].LicensePlate == licensePlate)
                {
                    list.RemoveAt(i);
                }
            }
        }

        //租车
        public double CarRental(string licensePlate,int rentDays)
        {
            foreach(var item in list)
            {
                if(item.LicensePlate == licensePlate)
                {
                    item.IsRent = true;
                    item.RentDays = rentDays;
                    return item.DailyPrice * rentDays;
                }
            }
            Console.WriteLine("输入的车牌号有误!");
            return 0;
        }
        //还车
        public void ReturnCar(string licensePlate,int realDays)
        {
            foreach (var item in list)
            {
                if( item.LicensePlate == licensePlate && item.IsRent == true)
                {
                    if(realDays > item.RentDays)
                    {
                        double price =  (realDays - item.RentDays) * item.DailyPrice * 2;
                        Console.WriteLine($"应当补足{price}元");
                        return;
                    }else
                    {
                        double price = (item.RentDays - realDays) * item.DailyPrice;
                        Console.WriteLine($"应当退还{price}元");
                        return;
                    }
                }
            }
        }
    }
}
