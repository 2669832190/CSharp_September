using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5 {
	public enum _sex {
		男,
		女,
		未知
	}
	internal class 课堂练习 {
		
		public static void maina () {
			Stu stu1 = new Stu("张三",_sex.男,20);
			Stu stu2 = new Stu("李四",18);
			stu1.print();
			stu2.print();

			Console.WriteLine("请输入学生姓名：");
			string name = Console.ReadLine();
			Console.WriteLine("请输入学生性别：");
			_sex sex= (_sex)System.Enum.Parse(typeof(_sex), Console.ReadLine());
			Console.WriteLine("请输入学生年龄：");
			int age = int.Parse(Console.ReadLine());
			Stu stu3 = new Stu(name ,sex , age);
			stu3.print();
			Console.WriteLine("请输入学生姓名：");
			string name1 = Console.ReadLine();
			Console.WriteLine("请输入学生年龄：");
			int age1 = int.Parse(Console.ReadLine());
			Stu stu4 = new Stu(name1 , age1);
			stu4.print();
		}
	}
	public class Stu {
		
		public void print () {
            Console.WriteLine(Name+Sex+this.Age);
        }
		public Stu ( string name , _sex sex , int age ) {
			this.Name = name;
			this.Sex = sex;
			this.age = age;
        }
		public Stu ( string name , int age ) {
			this.Name = name;
			this.Sex = _sex.未知;
			this.age = age;
		}
		string Name { get; set; }
		_sex Sex { get; set; }
		int Age;
		public int age {
			get { 
				return Age;
			}
			set {
				if ( value >= 0 && value <= 100 ) {
					Age = value;
				} else {
                    Console.WriteLine("年龄不合法");
                }
			}
		}
	}
}
