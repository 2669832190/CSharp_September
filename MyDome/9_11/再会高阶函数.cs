using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11 {
	public delegate void MyAction();
	public delegate T MyFunc<T1,T>(T1 x);

	internal class 再会高阶函数 {
		public static void maina() {
			MyAction myAction = T1;
			Test(myAction);


			MyFunc<string,int> myFunc = T2;
			Test2(myFunc);

		}


		//参数 action 传的是方法{ 没有返回值，没有参数 }
		public static void Test(MyAction myAction) {
			myAction();
		}


		//参数 需要符合MyFunc的标签
		//{第一个T1是参数类型string， 第二个T是返回值int}
		static void Test2(MyFunc<string,int> myFunc) {
            int a = myFunc("string");
            Console.WriteLine(a);
        }

		static void T1() {
            Console.WriteLine("T1运行了");
        }

		static int T2(string str) { 
			return str.Length;
		}

	}
}
