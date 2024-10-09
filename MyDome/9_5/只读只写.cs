using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5 {
	internal class 只读只写 {
		public static void maina () { 
			Student student = new Student();
			//设置类中私有的成员变量
			student.NameSet = "小明";
			//获取类中的私有成员变量
            Console.WriteLine(student.NameGat);

			Dog dog = new Dog();
			//获取Dog_name的初始值
            Console.WriteLine(dog.NameGet);
			//更改Dog_name的值
			dog.NameSet = "糖豆";
            //获取Dog_name的值
            Console.WriteLine(dog.NameGet);

			Console.Clear();
			Product product = new Product();
            Console.Write("请输入商品名字：");
            product.Name = Console.ReadLine();
            Console.Write("请输入商品价格：");
			product.Price = int.Parse(Console.ReadLine());
			product.print(product);
        }
	}
	public class Student {
		string _name;
		public string NameGat {
			get { 
				return _name;
			}
		}
		public string NameSet {
			set {
				_name = value;
			}
		}
	}

	public class Dog {
		//string _name;
		string _name = "二哈";

		//public string Name {
			//get 和 set 方法转 lambad表达式
			//get { return _name; }
			//get => _name;
			//set { _name = value; }
			//set => _name = value;
		//}

		public string NameGet { 
			get => _name;
		}
		public string NameSet { 
			set => _name = value;
		}
		//语法糖无初始值（自动生成一个新的字段）字段无判断条件的时候用
		public int Age { get; set; }
		//语法糖有初始值（自动生成一个新的字段）字段无判断条件的时候用
		public int Age1 { get; set; } = 10;

	}

	public class Product { 
		public string Name { get; set; }
		public string Sort { get; } = "生活用品类";
		int _price;
		public int Price {
			get => _price;
			set {
				if ( value <= 100 && value >= 1 ) {
					_price = value;
				} else {
                    Console.WriteLine("价格数据不合法！！！");
                }
			}
		}
		public void print (Product product) {
			if ( product.Price >= 1 && product.Price<=100 ) {
				Console.WriteLine("商品名：" + product.Name + "，\t商品分类：" + product.Sort + "，\t商品价格为：" + product.Price+"。");
			}
		}
	}
    
}
