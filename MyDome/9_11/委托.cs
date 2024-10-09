using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _9_11 {
	internal class 委托 {
		//委托 帮别人干活？
		//delegate 声明委托
		//delegate void MyDelegate() 表示能代理什么样的方法运行
		public delegate void MyDelegate();
		//我们这个委托 表示 能代理 {没有返回值，没有参数}的方法

		public delegate string MyDelegate1(int x);
		//我们这个委托 表示 能代理 {string返回值，int参数}的方法

		public static void maina() {
			//我们上面声明的委托 要作为类型使用
			//new 的时候 填入参数 也就是要代理的方法
			MyDelegate my = new MyDelegate(T1);

			my();
			MyDelegate1 my1 = new MyDelegate1(T2);
			string str = my1(123456);
            Console.WriteLine(str);


			//使用lambda表达式
			MyDelegate myDe = new MyDelegate(()=>Console.WriteLine("lambda表达式创建的没有名字的方法"));
			myDe();

			//赋值
			myDe = T1;
			myDe();


			myDe = delegate () { Console.WriteLine("通过委托创建的方法"); };
			myDe();


			MyDelegate1 myDelegate1 = delegate(int x){
                Console.WriteLine("x的值是："+x);
				return x+"";
            };
			myDelegate1(1234567890);



		}

		static void T1() {
            Console.WriteLine("T1运行了");
        }

		static string T2(int x) {
            Console.WriteLine("T2运行了 x的值是："+x);
			return "" + x;
        }




	}
}
