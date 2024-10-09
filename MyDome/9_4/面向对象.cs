using CSharp_September.MyDome._9_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4 {
	internal class 面向对象 {
		public static void Main ( string[] args ) {
			作业.maina();
			return;
			//什么叫面向对象
			//之前学习的都是面向过程：维护性差 扩展性差
			//面向对象是一种开发的思路

			//类
			//访问修饰符 class 类名{
			//	
			//}
			//类是需要new的 因为类是引用类型
			//结构体是值类型 不需要new

			//类相当于模板
			//对象是由类（模板）创建出来的具体的实例化对象

			Student student1 = new Student();
			student1._name = "小明";
			student1._gender = "男";
			student1._age = 18;
			student1.studentMessage(student1._name , student1._gender , student1._age);
			student1.Eat(student1._name);

			Student student2 = new Student();
			student2._name = "小红";
			student2._gender = "女";
			student2._age = 18;
			student2.studentMessage(student2._name,student2._gender,student2._age);
			student2.Eat(student2._name);











			//Program.maina();
			//私有字段.maina();
			//字段_属性.maina();
		}
	}
	//类
	public class Student {
		public string _name;
		public string _gender;
		public int _age;
		
		public void Eat(string _name) {
            Console.WriteLine("还有10分钟才放学，"+ _name + "已经冲到食堂了！！！");
        }
		public void studentMessage (string _name, string _gender,int _age ) {
            Console.WriteLine(_name+_gender+_age);
        }
	}
}
