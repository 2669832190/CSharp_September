using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5 {
	/// <summary>
	/// 静态类和非静态类
	/// </summary>
	internal class 非静态类 {
		public static void mainb () { 
			Cat cat = new Cat();
			cat.Name = "佩奇";
			cat.printName("乔治");
		}
	}
	public static class 静态类 {
		public static void maina () {
			//1.静态类中只能有静态变量和静态方法
			//2.静态类无法实例化
			//Dog1 dog = new Dog1();
			Dog1.printName();
            Console.WriteLine(Dog1.Name);
			
        }
	}
	public static class Dog1 {
		public static string Name = "二哈";
		//1.静态类中只能有静态变量和静态方法
		public static void printName () {
            Console.WriteLine(Name);
        }
	}

	public class Cat { 
		public string Name { get; set; }
		//this 的作用。
		//这个方法的功能是 输入一个名字， 修改原来的名字，并打印修改前后的名字
		public void printName (string Name) {
            Console.WriteLine("修改前的名字："+this.Name);
			this.Name = Name;
            Console.WriteLine("修改后的名字："+Name);
        }
	}
}
