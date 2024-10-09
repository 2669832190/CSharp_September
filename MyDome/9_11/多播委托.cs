using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11 {
	//多播委托
	//多播 多次播放
	public delegate void Mydelegate();
	internal class 多播委托 {
		
		public static void maina() { 
			Mydelegate Mydelegate = T11;
			Mydelegate += T12;
			Mydelegate += T13;
			Mydelegate += T14;
			Mydelegate();
            Console.WriteLine("----------------");
            Mydelegate -= T12;
			Mydelegate -= T13;
			Mydelegate();
		}
		static void T11() {
			Console.WriteLine("T1 运行了");
		}
		static void T12() {
			Console.WriteLine("T2 运行了");
		}
		static void T13() {
			Console.WriteLine("T3 运行了");
		}
		static void T14() {
			Console.WriteLine("T4 运行了");

		}
	}
	
}
