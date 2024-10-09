using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6 {
	internal class 继承 {
		public static void maina () { 
			Monkey monkey = new Monkey ();
			monkey.Age = 10;
			monkey.Weight =10.6;
			monkey.Color = "金色";
			monkey.CHLSS();
			monkey.Mating();

			// 私有的方法和属性 无法被继承
			//monkey.Fly();

			//受保护的 仅当前类内部和子类可以调用，外部类不可调用
			//monkey.Swimming();
			monkey.eatPeach();
		}
	}

	public class Animal {
		public int Age { get; set; }
		public double Weight { get; set; }
		public string Color { get; set; }

		public void CHLSS () {
			Console.WriteLine("动物吃喝拉撒睡");
		}

		public void Mating () {
			Console.WriteLine("动物可以交配");
		}

		//当前类可以访问 子类不可访问（子类不能继承）
		//私有的方法和属性 无法被继承
		private void Fly () {
			Console.WriteLine("有些动物可以飞");
		}

		//受保护的 仅当前类内部和子类可以调用，外部类不可调用
		protected void Swimming() {
            Console.WriteLine("有些动物能游泳");
        }
	}
	public class Monkey : Animal {
		public void eatPeach () {
            Console.WriteLine("吃桃");
			//Animal的子类可以游泳，外部类不可游泳
			this.Swimming();
        }

	} 
}
