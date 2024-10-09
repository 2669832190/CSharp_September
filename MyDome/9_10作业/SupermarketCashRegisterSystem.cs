using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10作业 {
	internal class SupermarketCashRegisterSystem {
		public static void maina() { 
			Supermarket supermarket = new Supermarket();
			#region 生成商品
			Product product0 = new Product("雷碧",3);
			Product product1 = new Product("中国劲酒",15);
			Product product2 = new Product("软中华",75);
			Product product3 = new Product("天叶",100);
			Product product4 = new Product("硬中华",45);
			Product product5 = new Product("江小白",18);
			Product product6 = new Product("红牛",6);
			#endregion
			#region 存入库存
			supermarket.Add(product0);
			supermarket.Add(product1);
			supermarket.Add(product2);
			supermarket.Add(product3);
			supermarket.Add(product4);
			supermarket.Add(product5);
			supermarket.Add(product6);
            #endregion
			supermarket.print();
            Console.WriteLine();
			supermarket.Removers(product3);
			supermarket.print();


			return;
			double SumMoney = 0;
            Console.Write("请输入您购买的商品样数：");
			int Count = int.Parse(Console.ReadLine());
			for ( int i = 0; i < Count; i++ ) {
				Console.Write("请输入您购买的商品ID：");
				int ID = int.Parse(Console.ReadLine());
				Console.Write("请输入您购买的商品数目：");
				int Num = int.Parse(Console.ReadLine());
				SumMoney += supermarket.CashRegister(ID,Num);
			}
			/*double SumMoney = supermarket.CashRegister(3,10);*/
			Console.WriteLine();
            Console.WriteLine("您的商品总价为："+SumMoney);
        }
	}

	/// <summary>
	/// 超市类
	/// </summary>
	public class Supermarket {
		#region 库存
		private Product[] products = new Product[0];
		/// <summary>
		/// 进货（添加库存）
		/// </summary>
		/// <param name="product">需要添加的商品</param>
		public void Add(Product product) {
			/*bool IsHave = false;
			foreach ( Product p in products ) {
				if ( p.Name == product.Name ) { 
					IsHave = true;

				}
			}
			if ( !IsHave ) {
				Array.Resize(ref products , products.Length + 1);
				products[products.Length - 1] = product;
			}*/
			Array.Resize(ref products , products.Length + 1);
			products[products.Length - 1] = product;
		}
		/// <summary>
		/// 出货（删除库存）
		/// </summary>
		/// <param name="product"></param>
		public void Removers(Product product) {
			for ( int i = 0; i < products.Length; i++ ) {
				if ( products[i].ID == product.ID ) {
					//Product[] temp = new Product[products.Length - 1];
					//products[products.Length - 1] = product;
					products[product.ID - 1] = products[products.Length - 1];
					Array.Resize(ref products , products.Length - 1);
					/*for ( int j = 0; j< products.Length; j++ ) {
						
					}*/
					
					
					//products = temp;
				}
			}

			/*
			Product[] temp = new Product[products.Length - 1];
			products[products.Length-1] = product;
			products[product.ID-1] = temp;
			Array.Resize(ref products , products.Length - 1);
			products = temp;
			*/
		}
		
		#endregion

		/// <summary>
		/// 收银
		/// </summary>
		/// <param name="ID">商品ID</param>
		/// <param name="Num">商品数量</param>
		/// <returns>总价钱</returns>
		public double CashRegister(int ID,int Num) {
			double SumMoney = 0;
			Product temp = null;
			foreach ( Product product in products ) {
				if ( product.ID == ID ) {
					temp = product;
				}
			}
			return SumMoney = temp.Price * Num;
        }

		/// <summary>
		/// 打印库存
		/// </summary>
		public void print() {
			//Product[] temp = new Product[products.Length];
			for ( int i = 0;i < products.Length; i++ ) {
				Console.WriteLine("ID:" + products[i].ID + "\t名称：" + products[i].Name + "\t价格：" + products[i].Price + "元");
			}
		}
	}

	/// <summary>
	/// 商品类
	/// </summary>
	public class Product { 
		public int ID { get; set; }
		public static int Id { get; set; } = 1;
		public string Name { get; set; }
		public double Price { get; set; }

		public Product(string Name, double Price) { 
			this.Name = Name;
			this.Price = Price;
			ID = Id;
			Id++;
		}

	}
}
