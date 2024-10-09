using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9 {
	internal class 部分类 {
		public static void maina () { 
			Student student = new Student();
			student.Name = "张三";
			student.Age = 18;
			student.Print();
		} 
	}

	//partial 部分类
	//类的一部分 可以通过多个部分 组成一个类
	//类名 需要相同

	public partial class Student { 
		public string Name { get; set; }
	}
	public partial class Student { 
		public int Age { get; set; }
	}
	public partial class Student {
		public void Print () {
            Console.WriteLine(Name + " : " + Age);
        }
	}
}
