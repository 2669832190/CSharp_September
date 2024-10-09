namespace ConsoleApp1 {
	
		public enum CarBand {
			奔驰,
			长城,
			丰田

		}

		internal class Program {
			static AutomobileBusiness rentalSystem = new AutomobileBusiness();
			static void Main(string[] args) {


				while ( true ) {
					// Car.Print();

					Console.WriteLine("请输入要进行的操作:1.添加汽车 2.删除汽车 3.租车 4.\r\n还车");
					int inputNum = Convert.ToInt32(Console.ReadLine());
					switch ( inputNum ) {
						case 1:
							//rentalSystem.AddCar();
							break;
						case 2:
							//rentalSystem.DeleteCar();
							break;
						case 3:
							//RentCar();
							break;
						case 4:
							//ReturnCar();
							return;

						default:
							Console.WriteLine("输入的数字有误，请重新输入！");
							break;
					}

				}
			}

		}
		public class Car {
			//品牌、
			public CarBand carBand { get; set; }
			//车型、
			public string VehicleType { get; set; }
			//车牌号、
			public string LicensePlateNumber { get; set; }
			//每日租金、
			public double DailyRent { get; set; }
			//总价
			public double Price { get; set; }
			//是否已租出、
			public bool IsRent { get; set; }
			//租借天数
			public int RentDays { get; set; }
			//租借日期
			public DateTime RentDate { get; set; }
		}
		public class AutomobileBusiness {
			private List<Car> list = new List<Car>();
			//当启动程序时，创建至少三条汽车信息用于测试。
			//1，添加汽车
			//当选择此项时，需要依次输入汽车的相关信息，随后将输入的信息添加进汽车信息。
			//打印所有车辆业务信息 用于测试
			public AutomobileBusiness() {
				Car car1 = new Car() { carBand = CarBand.奔驰, VehicleType = "奔驰300", LicensePlateNumber = "豫A123456", DailyRent = 190 };
				Car car2 = new Car() { carBand = CarBand.长城, VehicleType = "长城哈弗H6", LicensePlateNumber = "AB987654", DailyRent = 170 };
				Car car3 = new Car() { carBand = CarBand.丰田, VehicleType = "丰田埃尔法", LicensePlateNumber = "12345678", DailyRent = 110 };
				//添加到list
				list.Add(car1);
				list.Add(car2);
				list.Add(car3);

			}

			public void Print() {
				foreach ( Car car in list ) {
					Console.WriteLine($"品牌:{car.carBand},车型:{car.VehicleType},车牌号:{car.LicensePlateNumber},每日租金:{car.DailyRent},是否已租出:{car.IsRent},租借天数:{car.RentDays}");
				}
			}
			//2.删除汽车
			public void DeleteCar(string licensePlateNumber) {
				var car = list.FirstOrDefault(c => c.LicensePlateNumber == licensePlateNumber);
				if ( car != null ) {
					list.Remove(car);
					Console.WriteLine("汽车已删除。");
				} else {
					Console.WriteLine("未找到指定车牌号的汽车。");
				}
			}


			//3，租车
			//用户输入想租的车辆的车牌号，以及租借天数，计算出所需的金额。
			//已被租出的车辆不能被再次租出。
			public double RentCar(string VehicleType , int RentDays) {

				for ( int i = 0; i < list.Count; i++ ) {
					//找到要租借的车 并且 书的借出状态为false
					if ( list[i].VehicleType == VehicleType && !list[i].IsRent ) {
						//计算价格
						double money = RentDays * list[i].DailyRent;

						//改变书的状态
						list[i].IsRent = true;
						//list[i].RentDays = DateTime.Now;
						list[i].RentDays = RentDays;

						return money;
					}
				}

				//返回0代表没找到车型
				return 0;
			}
			//4，还车
			//1用户输入归还的车辆的车牌号，以及实际租借天数。
			//如果实际租出天数少于租车时填入的天数，退还相应的金额。
			//如果已超出租车时填入的天数，则需要按照每天双倍的金额补足租金。
			//输出应当退还还是应当补足金额。应当退还或补足多少。.

			public double ReturnCar(string VehicleType , string date) {
				for ( int i = 0; i < list.Count; i++ ) {
					if ( list[i].VehicleType == VehicleType && list[i].IsRent ) {
						list[i].IsRent = false;

						//找到车 计算还车日期
						DateTime dateTime = DateTime.Parse(date);
						//拿到应还车日期
						DateTime returnDate = list[i].RentDate.AddDays(list[i].RentDays);
						//实际还车日期 - 应还车日期
						TimeSpan timeSpan = dateTime - returnDate;
						//应当补钱
						if ( timeSpan.TotalDays > 0 ) {
							//应当支付的钱
							double money = timeSpan.TotalDays * list[i].DailyRent * 3;
							//是否大于车的价格
							if ( money >= list[i].Price ) {
								//返回车的价格
								return list[i].Price;
							}
							return money;
						}

					}
				}

				return 0;
			}


			static void RentCar() {
				Console.WriteLine("请输入要借的车名:");
				//书名
				string VehicleType = Console.ReadLine();
				Console.WriteLine("请输入要借的天数:");
				//借的天数
				int day = Convert.ToInt32(Console.ReadLine());


				//double money = Car.RentCar(VehicleType, RentDays);

				if ( money == 0 ) {
					Console.WriteLine("没有找到车或已经被借出！");
				} else {
					Console.WriteLine($"借车成功，需支付{money}元");
				}
			}

			//专门用于处理还车的方法
			static void ReturnCar() {
				Console.WriteLine("请输入要车的书名:");
				string VehicleType = Console.ReadLine();
				Console.WriteLine("请输入还车日期:");
				string date = Console.ReadLine();

				//还车交给车厂处理
				double money = Car.ReturnCar(VehicleType, RentDays);
				if ( money == 0 ) {
					Console.WriteLine("没有找到车或者没有被借出");
				} else {
					Console.WriteLine($"应当支付{money}钱");
				}
			}
		}
	
}
