using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9 {
	internal class 虚方法 {
		public static void maina () { 
			Clock clock = new Clock();
			Leader leader = new Leader();
			clock.Daka();
			leader.Daka();

			Clock clock1 = new Leader();
			clock1.Daka();

			Clock clock2 = new Principal();
			clock2.Daka();
		}
	}
	public class Clock {

		//virtual 虚方法
		//1.可以被重写（在子类中使用同名的方法）
		//2.提供一个默认实现的方法   子类继承后 可以有自己的实现 也可以使用父类提供的默认实现（多态）
		//当进行 new 的时候相当于隐藏子类的方法，使用默认的父类方法

		/*public void Daka () {
			Console.WriteLine("员工打卡时间：9点");
		}*/
		public virtual void Daka () {
            Console.WriteLine("员工打卡时间：9点");
        }
	}

	public class Leader : Clock {
		//加 override 对虚方法进行重写
		/*public void Daka () {
			Console.WriteLine("领导打卡时间：10点");
		}
		 * public override void Daka () {
			Console.WriteLine("领导打卡时间：10点");
		}*/

		public override void Daka () {
            Console.WriteLine("领导打卡时间：10点");
        }
		

		//当进行 new 的时候相当于隐藏子类的方法，使用默认的父类方法(父类 new 子类 的时候)
		/*public new void Daka () {
			Console.WriteLine("领导打卡时间：10点");
		}*/
	}
	public class Principal : Clock {
		public new void Daka () {
            Console.WriteLine("校长不打卡");
        }
	}
}
