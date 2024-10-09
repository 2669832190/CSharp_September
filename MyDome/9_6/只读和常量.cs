using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6 {
	internal class 只读和常量 {
		public static void maina () {
            Console.WriteLine("第一个student New之前");
            Student student = new Student(199);
			Console.WriteLine("第二个student New之前");
			Student student1 = new Student(198);
			Console.WriteLine("第二个student New之后");
			Student student2 = new Student(197);
			Console.WriteLine("第三个student New之前");

		}

	}

	
	public class Student {
		public string Name { get; set; }
		//只读的年龄
		public int Age { get; } = 10;

		//只读
		public readonly int Height = 200;

		//静态只读属性
		public static readonly int Weight;

		//常量 不能被修改 必需有初始值 自动为静态属性（不可加static）
		public const string Gender = "男" ;



		//静态构造函数 不能有访问修饰符
		//第一次 实例化对象的时候 被调用（只会调用一次）
		static Student () {
			Console.WriteLine("静态构造函数被调用了");
			Weight = 189;
			//常量任何时候都不能被修改值
			//Gender = "女";
		}


		//构造函数 new 的时候被调用
		public Student (int Height) { 
			this.Height = Height;
			//静态的方法才能调用静态的方法和静态的属性，所以这里不能被调用
			//this.Weight = Weight;
		}

		public void SetHeight ( int Height ) {
			//只读属性不能被赋值,静态只读只能在静态构造函数中赋值，只读只能在构造函数中赋值。
			//this.Height = Height;
			//Age = Height;
		}
	}

}
