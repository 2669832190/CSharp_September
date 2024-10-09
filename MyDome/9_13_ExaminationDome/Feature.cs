using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13_ExaminationDome {
	internal class Feature {
		/// <summary>
		/// 添加汽车
		/// </summary>
		/// <param name="Cars"></param>
		public void AddCat(List<CarMessage> Cars) {
			print(Cars);
            Console.Write("请输入汽车品牌：");
			string brandC = Console.ReadLine();
			E_Brand brand = (E_Brand)System.Enum.Parse(typeof(E_Brand) , brandC);
			Console.Write("请输入汽车型号：");
			string Model = Console.ReadLine();
			again1:
            Console.Write("请输入车辆的车牌号：");
			string Id = Console.ReadLine();
			if ( Id.Length == 8 ) {
			again:
				Console.Write("请输入每天的租金价格：");
				try {
					double num = double.Parse(Console.ReadLine());
					CarMessage carMessage = new CarMessage(brand,Model,num,Id);
					Cars.Add(carMessage);
					Console.WriteLine("添加成功！");
					print(Cars);
				} catch ( Exception ) {
					Console.WriteLine("租金价格不合法！！！\n请重新输入!");
					goto again;
				}
			} else {
                Console.WriteLine("您输入的车牌号不合法！！！\n请重新输入！");
				goto again1;
            }
        
        }

		/// <summary>
		/// 删除汽车
		/// </summary>
		/// <param name="Cars"></param>
		public void RemoveCat(List<CarMessage> Cars) {
			bool IsRemoveCar = false;
			print(Cars);
			Console.Write("请输入车牌号：");
			string CarId = Console.ReadLine();
			for ( int i = 0; i < Cars.Count; i++ ) {
				if ( Cars[i].ID == CarId ) {
					Cars.Remove(Cars[i]);
					IsRemoveCar = true;
				} 
			}
			if ( IsRemoveCar ) {
				Console.WriteLine("删除成功！");
				print(Cars);
			} else {
                Console.WriteLine("未找到车辆信息！");
            }
		}

		/// <summary>
		/// 租车
		/// </summary>
		/// <param name="Cars"></param>
		public void RentCat(List<CarMessage> Cars) { 
			Console.Clear();
			print(Cars);
            Console.Write("请输入您想要租的 车 的 车牌号：");
			string Id = Console.ReadLine();
			for ( int i = 0; i < Cars.Count; i++ ) {
				if ( Cars[i].ID == Id ) {
					if ( !Cars[i].IsRent ) {
					again:
						Console.Write("请输入您想要租的天数：");
						try {
							int days = int.Parse(Console.ReadLine());
							Cars[i].DayRentNum = days;
							Cars[i].IsRent = true;
							double money = days * Cars[i].DayRent;
							Console.WriteLine("请支付租金" + money + "万元。");
							Console.WriteLine("租赁成功！请按时还车！");
							break;
						} catch ( Exception ) {
							Console.WriteLine("您输入的天数不合法！！！\n请重新输入！");
							goto again;
						}
					} else {
                        Console.WriteLine("非常抱歉！您输入的车辆已被借出，暂时无法为您提供。");
                    }
				} else if(i == Cars.Count-1) {
                    Console.WriteLine("未找到车牌信息！！！");
                }
			}
        }

		/// <summary>
		/// 还车
		/// </summary>
		/// <param name="Cars"></param>
		public void ReturnCat(List<CarMessage> Cars) {
			Console.Clear();
			print(Cars);
            Console.Write("请输入想要归还的车辆的车牌号：");
			string Id = Console.ReadLine();
			for ( int i = 0; i < Cars.Count; i++ ) {
				if ( Cars[i].ID == Id ) {
					if ( Cars[i].IsRent ) {
                        Console.Write("请输入您实际租赁本车辆的天数：");
						int days = int.Parse(Console.ReadLine());
						if ( days > Cars[i].DayRentNum ) {
							Console.WriteLine("您已超出正常租赁天数！");
							double money = (days - Cars[i].DayRentNum) * Cars[i].DayRent * 2;
							Console.WriteLine("请支付超出的租金 " + money + " 万元。");
							Cars[i].IsRent = false;
							Console.WriteLine("还车成功！");
							break;
						} else if ( days < Cars[i].DayRentNum ) {
							double money = (Cars[i].DayRentNum - days) * Cars[i].DayRent;
							Console.WriteLine("由于您提前归还本车辆，我们还将退还您" + money + "万元。");
							Cars[i].IsRent = false;
							Console.WriteLine("还车成功！");
							break;
						} else {
							Cars[i].IsRent = false;
                            Console.WriteLine("还车成功！");
							break;
						}
					} else {
                        Console.WriteLine("您输入的车辆目前未被借出，无法归还。请确认车辆信息后再次归还。");
                    }
				} else if ( i == Cars.Count - 1 ) {
                    Console.WriteLine("未找到车辆信息！");
                }
			}
        }

		/// <summary>
		/// 打印车辆信息
		/// </summary>
		/// <param name="Cars"></param>
		public void print(List<CarMessage> Cars) {
			foreach ( CarMessage carMessage in Cars ) {
				if ( carMessage.IsRent ) {
					if ( carMessage.Brand == E_Brand.奥迪 ) {
						Console.WriteLine("车辆品牌：" + carMessage.Brand + "\t\t\t车辆型号：" + carMessage.VehicleType + " \t车牌号：" + carMessage.ID + " \t每日租金：" + carMessage.DayRent + "万元 \t是否已被租赁：" + carMessage.IsRent + " \t租赁天数：" + carMessage.DayRentNum+"\n");

					} else { 
						Console.WriteLine("车辆品牌：" + carMessage.Brand + " \t车辆型号：" + carMessage.VehicleType + " \t车牌号：" + carMessage.ID + " \t每日租金：" + carMessage.DayRent + "万元 \t是否已被租赁：" + carMessage.IsRent + " \t租赁天数：" + carMessage.DayRentNum + "\n");
					}
				} else {
					if ( carMessage.Brand == E_Brand.奥迪 ) {
						Console.WriteLine("车辆品牌：" + carMessage.Brand + "\t\t\t车辆型号：" + carMessage.VehicleType + " \t车牌号：" + carMessage.ID + " \t每日租金：" + carMessage.DayRent + "万元 \t是否已被租赁：" + carMessage.IsRent + "\n");

					} else {
						Console.WriteLine("车辆品牌：" + carMessage.Brand + " \t车辆型号：" + carMessage.VehicleType + " \t车牌号：" + carMessage.ID + " \t每日租金：" + carMessage.DayRent + "万元 \t是否已被租赁：" + carMessage.IsRent + "\n");

					}
				}
			}
		}
	}
}