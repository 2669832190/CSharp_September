using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_September.MyDome._9_4 {
	internal class 字段_属性 {
		public static void maina () { 
			Student student = new Student();
			//student._name
			//私有字段无法访问

			//设置Name的值
			//student.Name = "张三";
			//访问Name的值
            //Console.WriteLine(student.Name);

			//student.Age = -1;
            //Console.WriteLine(student.Age);

			Student1 student1 = new Student1();
			again:
            Console.WriteLine("请输入姓名：");
			string name = Console.ReadLine();
			student1.Name = name;
			if ( student1.Name == null ) { 
				goto again;
			}
			again1:
			Console.WriteLine("请输入年龄：");
			int age = int.Parse(Console.ReadLine());
			student1.Age = age;
			if ( student1.Age == -1 ) {
				goto again1;
			}
		}
	}
	//封装
	//封装底层逻辑 只给用户访问 设定好的内容

	public class Student {
		//字段
		private string _name;
		private int _age;
		//属性
		/*
		 属性 没有保存值
		 相当于中间商 字段的保镖
		当属性被访问时 会触发 get 方法 我们可以通过return字段 拿到字段的值
		当属性被修改时 会触发 set 方法 我们可以通过set方法设置字段里的值
		 */
		public string Name {
			get {
                Console.WriteLine("触发了 get 方法");
                return _name;
			}set {
                Console.WriteLine("触发了 set 方法 ，将值设置为" + value);
				_name = value;
            }
		}

		public int Age  {
			get {
				return _age;
			}set {
				if ( value <= 100 && value >= 0 ) {
					_age = value;
				} else {
					_age = 0;
                    Console.WriteLine("输入的年龄不合法，已自动设置为0");
                }
			}
		}
	}


	public class Student1 { 
		private string _name;
		private int _age;

		public string Name {
			get {
				return _name;
			}set {
				if ( IsNotName(value) ) {
					_name = value;
				} else {
					_name= null;
                    Console.WriteLine("输入的姓名不合法！");
                }
			}
		}
		public static bool IsNotName (string str) { 
			bool Isnotname = true;
			char[] chars = str.ToCharArray();
			for ( int i = 0; i < chars.Length; i++ ) {
				if ( chars[i] >= 48 && chars[i]<=57 ) { 
					Isnotname = false;
				}
			}
			return Isnotname;
		}


		public int Age {
			get {
				return _age;
			}
			set {
				if ( value <= 100 && value > 0 ) {
					_age = value;
				} else {
					_age = -1;
                    Console.WriteLine("输入的年龄不合法！");
                }
			}
		}
	}
}
