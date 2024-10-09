using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10 {
	internal class 索引器 {
		public static void maina() { 
			Animal0 animal0 = new Animal0();
			animal0.add("狗");
			animal0.add("猫");
			animal0.add("老鼠");

			animal0[0] = "老虎";
			Console.WriteLine(animal0[0]);

			
			animal0["猫"] = "鸟";
			Console.WriteLine(animal0["猫"]);
			Console.WriteLine(animal0["鸟"]);
        }
	}
	public class Animal0 { 
		private List<string> animals = new List<string>();
		public void add(string name) {
			animals.Add(name);
		}

		//索引器
		//访问修饰符 返回值类型 当前对象[规定索引类型 变量名]
		public string this[int index] {
			get => animals[index];
			set => animals[index] = value;
		}
		//自定义索引器
		public string this[string name] {
			get {
				foreach ( string item in animals ) {
					if ( item == name ) return item;
				}
				return null;
			}
			set {
				for ( int i = 0; i < animals.Count; i++ ) {
					if ( animals[i] == name ) {
						animals[i] = value;
					}
				}
			}
		}

	}

	public class Bird0 {
		public static void bird() { 
			Bird0 birds = new Bird0();
			birds.add("布谷鸟1号");
			birds.add("啄木鸟1号");
            Console.WriteLine("初次遍历鸟的数组为：");
			foreach ( var item in birds['a'] ) {
                Console.Write(item+" ");
            }
            Console.WriteLine();
			Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("开始修改值：");
            birds[0] = "布谷鸟2号";
			Console.WriteLine("改变布谷鸟1号的值为："+birds[0]);
			birds["啄木鸟1号"] = "啄木鸟2号";
            Console.WriteLine("通过值：啄木鸟2号查找到的值为："+birds["啄木鸟2号"]);
            Console.WriteLine("-----------------------------------------------\n");
            Console.WriteLine("修改之后的数组为：");
            foreach ( var item in birds['a'] ) {
				Console.Write(item + " ");
			}
            Console.WriteLine();
        }

		private string[] arr = new string[0];
		public void add(string name) { 
			Array.Resize(ref arr, arr.Length + 1);
			arr[arr.Length - 1] = name;
		}

		//索引器
		public string this[int index] { 
			get => arr[index];
			set { arr[index] = value; }
		}

		public string this[string name] {
			get {
				foreach ( string item in arr ) {
					if ( item == name ) {
						return item;
					}
				}
				return null;
			}
			set {
				for ( int i = 0; i < arr.Length; i++ ) {
					if ( arr[i] == name ) {
						arr[i] = value;
					}
				}
			}
		}

		public string[] this[char a] {
			get {
				string[] arr1 = new string[arr.Length];
				for ( int i = 0; i < arr.Length; i++ ) {
					arr1[i] = arr[i].ToString();
				}

				return arr1;
			}
		}
	}
}
