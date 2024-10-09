using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6 {
	internal class 继承的特性 {
		public static void maina () { 
			Animal1 animal1 = new Animal1 ("鳄鱼",6);
			Reptile reptile = new Reptile ("蜥蜴",3);
            Console.WriteLine(animal1.type);
            Console.WriteLine(reptile.type);
        }
	}

	public class Animal1 { 
		public string name { get; set; }
		public string type { get; set; } = "动物";
		public int age { get; set; }

		public Animal1 ( string name , string type , int age) { 
			this.name = name;
			this.type = type;
			this.age = age;
		}
		public Animal1 ( string name , int age ) {
			this.name = name;
			this.age = age;
		}
		public void CHLS () {
            Console.WriteLine("动物会吃喝拉撒");
        }

	}
	public class Reptile : Animal1 {
		//子类重新附默认值 当创建子类的时候 会使用子类的默认值
		public string type { get; set; } = "爬行动物";

		//base 调用父类的构造函数
		public Reptile ( string name , string type , int age ) : base(name , type , age) { }
		public Reptile ( string name , int age ) : base(name , age) { }

		public void Climb () {
            Console.WriteLine("会爬");
        }
	}

	public class Vehice { 
		public string type { get; set; }
		public int price { get; set; }
	}
}
