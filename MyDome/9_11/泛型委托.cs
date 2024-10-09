using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _9_11 {
	internal class 泛型委托 {
		//泛型委托
		//代理无返回值 有两个泛型参数
		public delegate void MyDelegate<T>(T x,T y);
		//代理有int返回值的 有两个泛型参数
		public delegate int MyDelegate1<T>(T x , T y);

		public static void maina() {
			MyDelegate<int> myDelegate = T1;
			myDelegate(10 , 20);
			MyDelegate<string> myDelegate1 = T2;
			myDelegate1("string" , "int");

			MyDelegate1<int> myDelegate2 = T3;
            Console.WriteLine("30+40 = "+myDelegate2(30 , 40));
            MyDelegate1<string> myDelegate3 = T4;
            Console.WriteLine("string的长度+int的长度 = "+myDelegate3("string" , "int"));
		}

		public static void T1(int x,int y) {
            Console.WriteLine("x+y="+(x+y));
        }
		public static int T3(int x , int y) {
			 return x + y;
		}

		public static void T2(string x,string y) {
            Console.WriteLine("x的长度+y的长度="+( x.Length + y.Length ));
        }
		public static int T4(string x , string y) {
			return x.Length + y.Length;
		}
	}
}
