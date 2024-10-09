using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9 {
	internal class 接口 {
		public static void maina () { 
			//接口不能进行实例化
			//Animaljk animaljk = new Animaljk();
		}

	}

	//interface 接口
	//定义规范 不能有初始值和方法体

	public interface Animaljk { 

		//接口中的属性不能有初始值和方法体
		public int leg { get; set; }

		void Eat ();
	}

	//使用接口（实现接口的功能）
	//不需要重写！！！
	public class Elephant : Animaljk {
		public int leg { get; set; } = 4;
		public void Eat () {
            Console.WriteLine("大象吃东西");
        }
	}

}
