namespace _09._13张超峰考试
{
    enum CardBrand
    {
        奔驰,
        宝马,
        大众,
        五菱,
        长城,
        丰田
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CarRentalSystem system = new CarRentalSystem();
            system.AddCar(CardBrand.奔驰, "Benz S300", "豫A00001", 500);
            system.AddCar(CardBrand.宝马, "BMW X5", "豫A00002", 400);
            system.AddCar(CardBrand.丰田, "Toyota Camry", "豫A00003", 300);
            system.AddCar(CardBrand.大众, "Magotan", "豫A00004", 300);
            system.AddCar(CardBrand.长城, "changchengPao", "豫A000005", 300);
            system.AddCar(CardBrand.五菱, "Wulingzhiguang", "豫A000006",200);

            bool running = true;
            while (running)
            {
                Console.WriteLine("\n1. 添加汽车\n2. 删除汽车\n3. 租车\n4. 还车\n5. 退出");
                Console.Write("请选择操作：");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("请输入品牌（1-奔驰，2-宝马，3-大众，4-五菱，5-长城，6-丰田）：");
                        int brandChoice = Convert.ToInt32(Console.ReadLine());
                        Console.Write("请输入车型：");
                        string model = Console.ReadLine();
                        Console.Write("请输入车牌号：");
                        string licensePlate = Console.ReadLine();
                        Console.Write("请输入每日租金：");
                        double dailyRent = Convert.ToDouble(Console.ReadLine());
                        system.AddCar((CardBrand)brandChoice, model, licensePlate, dailyRent);
                        break;
                    case 2:
                        Console.Write("请输入要删除的车牌号：");
                        string deletePlate = Console.ReadLine();
                        system.DeleteCar(deletePlate);
                        break;
                    case 3:
                        system.RentCar();
                        break;
                    case 4:
                        system.ReturnCar();
                        break;
                    case 5:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("无效的选择，请重新输入。");
                        break;
                }
            }
        }
    }
    class Car
    {
        //汽车品牌
        public CardBrand Brand { get; set; }

        //车型
        public string Model { get; set; }

        //车牌号
        public string LicensePlate { get; set; }

        //每日租金
        public double DailyRent { get; set; }

        //是否已租出
        public bool IsRentedOut { get; set; }

        //租借天数
        public int RentDays { get; set; }


        public Car(CardBrand brand, string model, string licensePlate, double dailyRent)
        {
            Brand = brand;
            Model = model;
            LicensePlate = licensePlate;
            DailyRent = dailyRent;
            IsRentedOut = false;
            RentDays = 0;
        }
    }

    // 定义汽车租赁系统类
    class CarRentalSystem
    {
        private List<Car> cars = new List<Car>();

        // 添加汽车
        public void AddCar(CardBrand brand, string model, string licensePlate, double dailyRent)
        {
            cars.Add(new Car(brand, model, licensePlate, dailyRent));
            Console.WriteLine("汽车添加成功。");
        }

        // 删除汽车
        public void DeleteCar(string licensePlate)
        {
            var car = cars.Find(c => c.LicensePlate == licensePlate);
            if (car != null)
            {
                cars.Remove(car);
                Console.WriteLine("汽车删除成功。");
            }
            else
            {
                Console.WriteLine("未找到该车牌号的汽车。");
            }
        }

        // 租车
        public void RentCar()
        {
            Console.WriteLine("请选择要租的车辆(输入车牌号即可租车)：");
            PrintCars();
            string licensePlate = Console.ReadLine();
            int rentDays;
            bool success = int.TryParse(Console.ReadLine(), out rentDays);
            if (!success || rentDays <= 0)
            {
                Console.WriteLine("请输入有效的租借天数。");
                return;
            }

            var car = cars.Find(c => c.LicensePlate == licensePlate);
            if (car != null && !car.IsRentedOut)
            {
                car.IsRentedOut = true;
                car.RentDays = rentDays;
                Console.WriteLine($"租车成功。车牌号：{car.LicensePlate}，租金：{car.DailyRent * rentDays}。");
            }
            else
            {
                Console.WriteLine("该车辆已被租出或不存在。");
            }
        }

        // 还车
        public void ReturnCar()
        {
            Console.WriteLine("请选择要还的车辆：");
            PrintCars();
            string licensePlate = Console.ReadLine();
            int actualRentDays;
            bool success = int.TryParse(Console.ReadLine(), out actualRentDays);
            if (!success || actualRentDays <= 0)
            {
                Console.WriteLine("请输入有效的实际租借天数。");
                return;
            }

            var car = cars.Find(c => c.LicensePlate == licensePlate);
            if (car != null && car.IsRentedOut)
            {
                double refund = 0;
                double penalty = 0;
                if (actualRentDays < car.RentDays)
                {
                    refund = (car.RentDays - actualRentDays) * car.DailyRent;
                    Console.WriteLine($"退还金额：{refund}。");
                }
                else if (actualRentDays > car.RentDays)
                {
                    penalty = (actualRentDays - car.RentDays) * car.DailyRent * 2;
                    Console.WriteLine($"需要补足金额：{penalty}。");
                }

                car.IsRentedOut = false;
                car.RentDays = 0;
                Console.WriteLine($"还车成功。车牌号：{car.LicensePlate}。");
            }
            else
            {
                Console.WriteLine("该车辆未被租出或不存在。");
            }
        }

        // 打印所有车辆信息
        private void PrintCars()
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"车牌号：{car.LicensePlate}, 品牌：{car.Brand}, 车型：{car.Model}, 是否已租出：{car.IsRentedOut}");
            }
        }
    }
}
