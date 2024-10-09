using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5 {
	internal class 析构函数 {
		public static void maina () {
			//红色鸵鸟
			Bird bird1= new Bird(2200,Colour.红);
			//下蛋
			bird1.layEggs();
		}
	}
	public enum Colour {
		红,
		橙,
		黄,
		绿,
		青,
		蓝,
		紫,
		黑
	}

	public class Bird { 
		public double Weight { get; set; }
		public Colour Colour { get; set; }


		public Bird( double weight , Colour colour) { 
			this.Weight = weight;
			this.Colour = colour;
		}
		//下蛋
		public void layEggs () {
            Console.WriteLine("开始下蛋");
        }

		//析构函数
		//对象死掉的时候调用
		//比如：程序运行结束了
		//准确来说，是当内存释放时会调用
		//GC:垃圾回收器 定期会找内存中 哪些东西用不到了 然后回收内存
		~Bird () {
            Console.WriteLine("鸟死了");
        }
	}
}
