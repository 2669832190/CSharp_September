using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_13_ExaminationDome {
	/// <summary>
	/// 车辆品牌枚举
	/// </summary>
	public enum E_Brand {
		英国豪华汽车劳斯莱斯,
		意大利汽车生产商,
		奥迪,
		德国大众汽车集团
	}

	/// <summary>
	/// 车群
	/// </summary>
	internal class Car {
		/// <summary>
		/// 构造Car,返回车群
		/// </summary>
		public List<CarMessage> CarMessages() {
			List<CarMessage> Cars = new List<CarMessage>();
			CarMessage car1 = new CarMessage(E_Brand.英国豪华汽车劳斯莱斯,"劳斯莱斯银魅",15.5);
			CarMessage car2 = new CarMessage(E_Brand.意大利汽车生产商,"兰博基尼",3.8);
			CarMessage car3 = new CarMessage(E_Brand.奥迪,"奥迪派克峰",2.7);
			CarMessage car4 = new CarMessage(E_Brand.意大利汽车生产商,"法拉利FXXK",1.2);
			CarMessage car5 = new CarMessage(E_Brand.德国大众汽车集团,"布加迪威龙",1.1);
			Cars.Add(car1);
			Cars.Add(car2);
			Cars.Add(car3);
			Cars.Add(car4);
			Cars.Add(car5);
			return Cars;
		}
	}

	/// <summary>
	/// 车辆信息
	/// </summary>
	public class CarMessage { 
		/// <summary>
		/// 品牌
		/// </summary>
		public E_Brand Brand { get; set; }
		/// <summary>
		/// 车型
		/// </summary>
		public string VehicleType { get; set; }
		/// <summary>
		/// 车牌
		/// </summary>
		public string ID { get; set; }
		/// <summary>
		/// 每日租金
		/// </summary>
		public double DayRent { get; set; }
		/// <summary>
		/// 是否已被借出
		/// </summary>
		public bool IsRent { get; set; }
		/// <summary>
		/// 租赁天数
		/// </summary>
		public int DayRentNum { get; set; } = 0;
		/// <summary>
		/// 正常构造赋值
		/// </summary>
		public CarMessage(E_Brand Brand, string VehicleType, double DayRent) { 
			this.Brand = Brand;
			this.VehicleType = VehicleType;
			this.DayRent = DayRent;
			#region 车牌号生成
			char[] chars = new char[8];
			chars[0] = '豫';
			Random random = new Random();
			int num = random.Next(65,91);
			chars[1] = (char)num;
			for ( int i = 2; i < chars.Length; i++ ) { 
				Random random1 = new Random();
				int num0 = random1.Next(0,2);
				if ( num0 == 0 ) {
					Random random2 = new Random();
					int nums = random2.Next(65,91);
					chars[i] = (char)nums;
				} else { 
					Random random2 = new Random();
					int nums = random2.Next(48,57);
					chars[i] = (char)nums;
				}
			}
			for ( int i = 0; i < chars.Length; i++ ) {
				this.ID += chars[i].ToString();
			}
			#endregion
		}
		/// <summary>
		/// 重载(添加汽车时对车辆车牌号重新赋值)
		/// </summary>
		public CarMessage(E_Brand Brand , string VehicleType , double DayRent,string Id)  : this(Brand,VehicleType,DayRent) { 
			this.ID = Id;
		}
	}
}