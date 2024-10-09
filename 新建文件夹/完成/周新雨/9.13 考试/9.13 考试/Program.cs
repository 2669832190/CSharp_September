using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _9._13_考试
{
	internal class Program {
		static CarSystem carsystem=new CarSystem();

		static void Main(string[] args) {
			Console.WriteLine("欢迎来到汽车租赁公司");
			while ( true ) {
				carsystem.Print();

				Console.WriteLine("请输入要进行的操作：1.添加汽车 2.删除汽车 3.租车 4.还车 ");
				int num =int.Parse(Console.ReadLine());
				switch ( num ) {
					case 1:
						Addcar();
						break;
					case 2:
						Delcar();
						break;
					case 3:
						Borrow();
						break;
					case 4:
						BackCar();
						break;

				}
			}

		}
		static void Addcar() {
			Brand c = new Brand();
			Console.WriteLine("请输入汽车品牌: 1奔驰 2宝马 3奥迪 4五菱 5长城 6丰田");
			int a =int.Parse(Console.ReadLine());
			switch ( a ) {
				case 1:
					c = Brand.奔驰;
					break;
				case 2:
					c = Brand.宝马;
					break;
				case 3:
					c = Brand.奥迪;
					break;
				case 4:
					c = Brand.五菱;
					break;
				case 5:
					c = Brand.长城;
					break;
				case 6:
					c = Brand.丰田;
					break;
			}
			Console.WriteLine("请输入汽车车型");
			string d=Console.ReadLine();
			Console.WriteLine("请输入汽车车牌号");
			string e =Console.ReadLine();
			Console.WriteLine("请输入每日租金");
			double f = double.Parse( Console.ReadLine());
			carsystem.ADD(c , d , e , f);
		}

		static void Delcar() {
			Console.WriteLine("请输入汽车的车牌号");
			string a =Console.ReadLine();
			carsystem.Dellcar(a);
		}

		static void Borrow() {
			Console.WriteLine("请输入租车的车牌号");
			string a = Console.ReadLine();
			Console.WriteLine("请输入租借的天数");
			double b = double.Parse( Console.ReadLine());
			carsystem.Borrow(a , b);
		}

		static void BackCar() {
			Console.WriteLine("请输入归还车辆的车牌号");
			string a =Console.ReadLine();
			Console.WriteLine("请输入实际租借的天数");
			double d = double.Parse( Console.ReadLine());
			carsystem.BackCar(a , d);
		}
	}


	public enum Brand {
		奔驰=1, 宝马, 奥迪, 五菱, 长城, 丰田
	}
	public class Car {
		public Brand Brand { get; set; }
		public string Models { get; set; }
		public string CarPlate { get; set; }
		public double DayPrice { get; set; }
		public bool Lend { get; set; }
		public double LendDays { get; set; }
		public DateTime Relend { get; set; }
	}

	public class CarSystem {
		public List<Car> cars=new List<Car>();

		public CarSystem() {
			Car car1= new Car() { Brand=Brand.奔驰,Models="奔驰300",CarPlate="豫B999999",DayPrice=200,Lend=false,LendDays=0};
			Car car2= new Car() { Brand=Brand.宝马,Models="宝马X7",CarPlate="豫A666666",DayPrice=600,Lend=false,LendDays=0};
			Car car3= new Car() { Brand=Brand.奥迪,Models="奥迪Rs7",CarPlate="沪A888888",DayPrice=900,Lend=false,LendDays=0};

			cars.Add(car1);
			cars.Add(car2);
			cars.Add(car3);
		}
		public void Print() {
			foreach ( Car c in cars ) {
				Console.WriteLine($"品牌:{c.Brand} 车型:{c.Models} 车牌号:{c.CarPlate} 每日租金:{c.DayPrice} 是否已租出:{c.Lend} 租接天数:{c.LendDays}");
			}

		}
		public void ADD(Brand a , string b , string c , double d) {
			cars.Add(new Car() { Brand = a , Models = b , CarPlate = c , DayPrice = d , Lend = false , LendDays = 0 });
		}
		public void Dellcar(string a) {
			for ( int i = 0; i < cars.Count; i++ ) {
				if ( cars[i].CarPlate == a ) {
					cars.Remove(cars[i]);
				}

			}

		}

		public void Borrow(string a , double b) {

			foreach ( Car c in cars ) {
				if ( c.CarPlate == a && c.Lend == false ) {
					Console.WriteLine($"需要支付{c.DayPrice * b}元");
					c.Lend = true;
					c.LendDays = b;
					return;
				}
			}
			Console.WriteLine("未找到符合条件的车辆");

		}

		public void BackCar(string a , double b) {
			foreach ( Car c in cars ) {
				if ( c.CarPlate == a ) {
					if ( c.LendDays > b ) {
						Console.WriteLine($"应当退还金额，退还金额{( c.LendDays - b ) * c.DayPrice}");
						break;
					} else if ( c.LendDays < b ) {
						Console.WriteLine($"应当补足金额，补足金额{( b - c.LendDays ) * c.DayPrice * 2}");
						break;
					} else {
						Console.WriteLine("归还完成");
					}
				}
			}

		}

	}
}
