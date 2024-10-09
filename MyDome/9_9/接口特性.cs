using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9 {
	internal class 接口特性 {
		public static void maina () { 
			
		}
	}

	public interface Reptile { 
		int leg { get; set; }
		void Climb();
	}

	public interface FlyAnimals {
		void Fly();
	}

	public interface Mammal {
		void DrinkMilk();
	}

	public class Animal0 { 
	
	}

	//接口可以继承多个
	//类只能继承一个
	//接口和类的继承可以合在一起
	public class Cicada :Animal0, Reptile, FlyAnimals, Mammal { 
		public int leg { get; set; }
		public void Climb () {
            Console.WriteLine("知了在地上爬");
        }

		public void Fly () {
            Console.WriteLine("知了在天上飞   ");
        }

		public void DrinkMilk () {
            Console.WriteLine("知了在喝牛奶");
        }

	}
}
