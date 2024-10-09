using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_考试 
{
    //车辆的品牌
    public enum CarBrand
    {
        奔驰,
        宝马,
        大众,
        劳斯莱斯,
        帕加尼,
        丰田
    }
    // 车辆的类  
    public class Car
    {
        public CarBrand Brand { get; set; }
        public string Model { get; set; }
        public string PlateNumber { get; set; }
        public decimal DailyRent { get; set; }
        public bool IsRented { get; set; }
        public int RentDays { get; set; }
        public Car(CarBrand brand, string model, string plateNumber, decimal dailyRent)
        {
            Brand = brand;
            Model = model;
            PlateNumber = plateNumber;
            DailyRent = dailyRent;
            IsRented = false;
            RentDays = 0;
        }
        public override string ToString()
        {
            return $"{Brand} {Model}, 车牌号: {PlateNumber}, 每日租金: {DailyRent}元, 已租出: {IsRented}, 租借天数: {RentDays}";
        }
    }

    // 车辆租赁系统 
    //CarRentalSystem租赁系统类名
    public class CarRentalSystem
    {
        private List<Car> cars = new List<Car>();
        // 开始测试车辆  
        public CarRentalSystem()
        {
            cars.Add(new Car(CarBrand.奔驰, "奔驰E300", GeneratePlateNumber(), 800));
            cars.Add(new Car(CarBrand.宝马, "宝马X7", GeneratePlateNumber(), 750));
            cars.Add(new Car(CarBrand.大众, "大众途观", GeneratePlateNumber(), 500));
            cars.Add(new Car(CarBrand.帕加尼, "风之子", GeneratePlateNumber(), 3500));
            cars.Add(new Car(CarBrand.劳斯莱斯, "库里南",GeneratePlateNumber(), 2500));
            cars.Add(new Car(CarBrand.丰田, "酷路泽",GeneratePlateNumber(), 1000));
        }
        Random random = new Random();
        private string GeneratePlateNumber()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, 8).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        // 添加汽车  
        public void AddCar()
        {
            Console.WriteLine("请输入品牌：");
            var brandInput = Console.ReadLine();
            CarBrand brand;
            if (!Enum.TryParse(brandInput, out brand))
            {
                Console.WriteLine("没有");
                return;
            }
            Console.WriteLine("请输入车型：");
            var model = Console.ReadLine();
            string plateNumber = GeneratePlateNumber();
            Console.WriteLine("每日租金：");
            if (!decimal.TryParse(Console.ReadLine(), out decimal dailyRent))
            {
                Console.WriteLine("无效租金");
                return;
            }
            var car = new Car(brand, model, plateNumber, dailyRent);
            cars.Add(car);
            Console.WriteLine($"添加成功！请输入车牌号：{car.PlateNumber}");
        }
        // 删除汽车  
        public void DeleteCar()
        {
            Console.WriteLine("请输入车牌号：");
            var plateNumber = Console.ReadLine();
            var carToRemove = cars.FirstOrDefault(car => car.PlateNumber == plateNumber);
            if (carToRemove != null)
            {
                cars.Remove(carToRemove);
                Console.WriteLine("删除成功！");
            }
            else
            {
                Console.WriteLine("没有找到车辆，是否输入错误车牌号");
            }
        }
        public void RentCar()
        {
            ShowCars();
            Console.WriteLine("请输入想租的车牌号：");
            var plateNumber = Console.ReadLine();
            Console.WriteLine("请输入租借天数：");
            if (!int.TryParse(Console.ReadLine(), out int rentDays))
            {
                Console.WriteLine("无效的租借天数");
                return;
            }
            var carToRent = cars.FirstOrDefault(car => car.PlateNumber == plateNumber);
            if (carToRent != null)
            {
                if (carToRent.IsRented)
                {
                    Console.WriteLine("该车辆已被租出，无法再次租出。");
                }
                else
                {
                    carToRent.IsRented = true;
                    carToRent.RentDays = rentDays;
                    decimal amountDue = carToRent.DailyRent * rentDays;
                    Console.WriteLine($"租车成功！应付金额：{amountDue}元");
                }
            }
            else
            {
                Console.WriteLine("未找到该车牌号的车辆");
            }
        }
        public void ShowCars()
        {
            Console.WriteLine("可用车辆信息：");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
        // 还车  
        public void ReturnCar()
        {
            ShowCars();
            Console.WriteLine("请输入归还的车牌号：");
            var plateNumber = Console.ReadLine();
            Console.WriteLine("请输入实际租借天数：");
            if (!int.TryParse(Console.ReadLine(), out int actualRentDays))
            {
                Console.WriteLine("你闹呢，输入正确的租借天数");
                return;
            }
            var carToReturn = cars.FirstOrDefault(car => car.PlateNumber == plateNumber && car.IsRented);
            if (carToReturn != null)
            {
                carToReturn.IsRented = false;
                if (actualRentDays < carToReturn.RentDays)
                {
                    decimal refund = (carToReturn.RentDays - actualRentDays) * carToReturn.DailyRent;
                    Console.WriteLine($"退还金额：{refund}元");
                }
                else
                {
                    int additionalDays = actualRentDays - carToReturn.RentDays;
                    // 每天双倍租金  
                    decimal additionalAmount = additionalDays * carToReturn.DailyRent * 2;
                    Console.WriteLine($"补足金额：{additionalAmount}元");
                }
                // 清零租借天数
                carToReturn.RentDays = 0;
            }
            else
            {
                Console.WriteLine("未找到该牌照打的车或者没有被租出");
            }
        }
        public void Run()
        {
            Console.WriteLine("车辆租赁系统");
            while (true)
            {
                Console.WriteLine("\n请选择操作：");
                Console.WriteLine("1. 添加汽车");
                Console.WriteLine("2. 删除汽车");
                Console.WriteLine("3. 租车");
                Console.WriteLine("4. 还车");
                Console.WriteLine("5. 退出");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        DeleteCar();
                        break;
                    case "3":
                        RentCar();
                        break;
                    case "4":
                        ReturnCar();
                        break;
                    case "5":
                        Console.WriteLine("谢谢使用！");
                        return;
                    default:
                        Console.WriteLine("无效选择，请重新输入。");
                        break;
                }
            }
        }
        public static void Main(string[] args)
        {
            CarRentalSystem system = new CarRentalSystem();
            system.Run();
        }
    }
}
