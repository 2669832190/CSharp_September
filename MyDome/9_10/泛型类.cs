using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _9_10 {
	internal class 泛型类 {
		public static void maina() {
			Animal<int> animal = new Animal<int>();
			animal.Value = 100;
            Console.WriteLine(animal.Value);

			Bird<int,string> bird = new Bird<int,string>();


			Cukoo<string> cukoo = new Cukoo<string>();
			string s = cukoo.Fly("起飞");
            Console.WriteLine(s);
        }
	}


	//泛型类
	public class Animal<T> {
		public T Value { get; set; }
	}
	public class Bird<T, T1> : Animal<T> { 
		public T1 leg { get; set; }
	}



	//泛型接口
	public interface FlyingAnimals<T> { 
		//返回值类型 方法名（参数类型 参数名）
		T Fly(T howtofly);
	}

	public class Cukoo<T> : FlyingAnimals<T> {
		//访问修饰符 返回值类型 方法名（参数类型 参数名）
		//参数类型和返回值一样
		public T Fly(T howtofly) {
			return howtofly;
		}
	}


}
