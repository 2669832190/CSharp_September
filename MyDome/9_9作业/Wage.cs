using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9作业 {
	internal class Wage {
		public static void maina () { 
			Citizen citizen = new Citizen ();
			Citizen programmer = new Programmer ();
			Citizen dustman = new Dustman ();
			Citizen deliveryBoy = new DeliveryBoy ();
			Citizen dripping = new Dripping ();
			Citizen sell = new Sell ();
			citizen.Wages();
			programmer.Wages();
			dustman.Wages();
			deliveryBoy.Wages();
			dripping.Wages();
			sell.Wages();
		}
	}

	public class Citizen {
		public virtual void Wages () {
            Console.WriteLine("市民的基本工资为：3500。\n");
        }
	}
	public class Programmer : Citizen {
		public override void Wages () {
			Console.WriteLine("程序猿的基本工资为：7.5k。\n");
		}
	}
	public class Dustman : Citizen {
		public override void Wages () {
			Console.WriteLine("清洁工的基本工资为：2.5k。\n");
		}
	}
	public class DeliveryBoy : Citizen {
		public override void Wages () {
			Console.WriteLine("外卖小哥的基本工资为：8k。\n");
		}
	}
	public class Dripping : Citizen {
		public override void Wages () {
			Console.WriteLine("滴滴的基本工资为：7k。\n");
		}
	}
	public class Sell : Citizen {
		public override void Wages () {
			Console.WriteLine("销售的基本工资为：0 - 2W。\n");
		}
	}
	


}
