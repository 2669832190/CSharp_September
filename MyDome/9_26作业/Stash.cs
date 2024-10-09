using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_26作业 {
	internal class Stash {
		
		/// <summary>
		/// 仓库中产品的初始数量
		/// </summary>
		private int num;
		private static readonly object lockObject = new object();

		private static Stash _instance = null;
		private static readonly object _instanceLock = new object();
		/// <summary>
		/// 实例化仓库
		/// </summary>
		private Stash(int num) {
			this.num = num;
		}

		public static Stash GetStash(int num) {
			if ( _instance == null ) {
				lock ( _instanceLock ) {
					if ( _instance == null ) {
						_instance = new Stash(num);
					}
				}
			}

			return _instance;
		}


		/// <summary>
		/// 产品添加
		/// </summary>
		public void Addnum() {
			while ( true ) {
				lock ( lockObject ) {
					if ( num < 30 ) {
						this.num++;
						Console.WriteLine($"{Thread.CurrentThread.Name}进行了添加产品的操作，产品的数量为:" + this.num);
					} else {
                        Console.WriteLine("仓库已满，不可再生产！");
						break;
                    }
					
				}
				Thread.Sleep(500);

			}
		}

		/// <summary>
		/// 商品删除
		/// </summary>
		public void Removenum() {
			while ( true ) {
				lock ( lockObject ) {
					if ( num > 0 ) {
						this.num--;
						Console.WriteLine($"{Thread.CurrentThread.Name}进行了删除产品的操作，产品的数量为:" + this.num);
					} else {
                        Console.WriteLine("产品已消费完，不可再次消费！");
						break;
                    }
                    
				}
				Thread.Sleep(500);

			}
		}

		/// <summary>
		/// 获取产品的数目
		/// </summary>
		public void getnum() {
			while ( true ) {
				lock ( lockObject ) {
					Console.WriteLine("商品的数量为:" + this.num);
				}
				//每输出一次计数器的值 等待0.8秒
				Thread.Sleep(800);
			}
		}


		public void add(Thread[] production , Stash stash) {
			for ( int i = 0; i < production.Length; i++ ) {
				production[i] = new Thread(stash.Addnum);
				production[i].Name = "生产线程" + ( i + 1 );
				production[i].Start();
			}
		}

		public void remove(Thread[] consumption , Stash stash) {
			for ( int i = 0; i < consumption.Length; i++ ) {
				consumption[i] = new Thread(stash.Removenum);
				consumption[i].Name = "消费线程 " + ( i + 1 );
				consumption[i].Start();
			}
		}
	}
}
