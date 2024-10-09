using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5 {
	internal class 构造函数 {
		public static void maina () { 
			Student2 student1 = new Student2();
            Console.WriteLine("年龄："+student1.Age);

			Student2 student2 = new Student2("张三",20);
            Console.WriteLine("名字是："+student2.Name+",年龄是"+student2.Age);

			Student2 student3 = new Student2("李四");
            Console.WriteLine("名字是：" + student3.Name + ",年龄是" + student3.Age);
        }
	}

	public class Student2 {
		public string Name { get; set; }
		public int Age { get; set; }
		public Student2 () {
            Console.WriteLine("调用了构造函数");
			Age = 18;
        }

		//方法重载 根据传递的参数 自动决定调用哪一个
		public Student2 (string name , int age) {
            Console.WriteLine("调用了带参数的构造函数");
			this.Name = name;
			this.Age = age;
        }

		//构造函数链
		public Student2 ( string name ) : this(name , 19) { }
	}


}
