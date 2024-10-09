using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9 {
	internal class 抽象类 {
		public static void maina () { 
			//抽象类无法被实例化
			//Animal animal = new Animal();
			
			Animal animal = new Bird();
			
		}
	}
	//重点：
	//1.抽象方法或抽象属性必须写在抽象类中
	//2.抽象类的子类必须使用override重写父类的抽象方法或抽象属性
	//3.抽象类无法被实例化
	//4.抽象类中可以包括非抽象成员


	public abstract class Animal{
		
		//抽象属性不能有初始值
		public abstract int legnum { get; set; }

		

		//抽象方法 不能有方法体
		//定义了一个规范 子类必须重抽象方法
		public abstract void Call();


		//抽象类中可以包括非抽象成员
		public void Eat () {
            Console.WriteLine("动物吃东西");
        }
	}

	public class Bird : Animal {
		public override int legnum { get; set; } = 2;

		//子类必须重写父类的抽象方法
		public override void Call () {
            Console.WriteLine("布谷布谷");
        }
	}
}
