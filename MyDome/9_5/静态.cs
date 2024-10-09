using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5 {
	internal class 静态 {
		public static void maina () {
			Student1.proFessionalName = "计算机专业";
            Console.WriteLine(Student1.proFessionalName);

			Student1 student1 = new Student1();
			student1.Name = "张三";

			Student1.jingtai();
			student1.feijingtai();
        }
	}

	public class Student1 {
		public string Name { get; set; }

		//1.不属于实例化对象，而是属于类
		//调用的时候，通过类名.属性名调用

		//2.静态的变量，方法 ，在程序运行时，就会被创建

		public static string proFessionalName { get; set; }

		public static void jingtai () {
			//静态方法中，只能调用静态属性
			//静态方法调用时，通过类名.属性名调用
			Console.WriteLine("这是一个静态方法");
            Console.WriteLine("在静态的方法里输出专业名称："+Student1.proFessionalName);
        }

		public void feijingtai () {
            Console.WriteLine("这是一个非静态方法");
			//非静态方法里，可以调用静态和非静态属性
			Console.WriteLine("在非静态方法里输出专业名称："+Student1.proFessionalName);
			//this 这个对象本身
            Console.WriteLine("在非静态方法里输出名字"+ this.Name);
        }
	}

}
