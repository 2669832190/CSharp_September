using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 唐老师练习dome {
	internal class _1 {
		/// <summary>
		/// 人类，学生，食物
		/// </summary>
		public static void T1() { 
			people p = new people();
			p.Speak();
			p.Walk();
			p.Eat();
			Student student = new Student();
			student.Study();
			student.Eat();
			Food food = new Food();
			food.name = "面包";
			food.heat = 100;

			p.Eat(food);
			student.Eat(food);
		}

		public static void T2() {
			again:
            Console.Write("请输入距离：");
			double distance = double.Parse(Console.ReadLine());
			if ( distance > 0 ) {
				Ticket ticket = new Ticket(distance);
				ticket.Print();
			} else {
				goto again;
			}
        }
	}

	public class people {

		public void Speak() {
            Console.WriteLine("说话");
        }
		public void Walk() {
			Console.WriteLine("走路");
		}
		public void Eat() {
			Console.WriteLine("吃饭");
		}

		public void Eat(Food food) {
			Console.WriteLine("吃"+ food.name+",热量为："+food.heat);
		}
	}
	public class Student {
		public void Study() {
            Console.WriteLine("学习");
        }
		public void Eat() {
			Console.WriteLine("吃饭");
		}

		public void Eat(Food food) {
			Console.WriteLine("吃" + food.name + ",热量为：" + food.heat);
		}
	}
	public class Food {
		public string name;
		public int heat;
	}

	public class Ticket {
		public double distance;
		public double Price;
		public Ticket(double distance) {
			this.distance = distance;	
			this.Price = GetPrice();
		}
		double GetPrice() { 
			double price = 0;
			if ( distance <= 100 ) {
				price = distance;
			} else if ( distance > 100 && distance <= 200 ) {
				price = distance * 0.95;
			} else if ( distance > 200 && distance <= 300 ) {
				price = distance * 0.9;
			} else { 
				price = distance * 0.8;
			}
			return price;
		}
		public void Print() {
            Console.WriteLine("这张票的价钱为" + Price + "。");
        }
	}
}
