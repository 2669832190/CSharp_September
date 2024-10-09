using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10 {
	internal class 泛型 {
		public static void maina () {
			Test<int>(10);	
			Test<string>("abc");
			//不填写< > 里的类型的时候，它会根据传入的参数自动识别类型
			Test('a');

			Test<int , string , char>(10 , "abc" , 'z');

		}
		//泛型 广泛的类型
		//传入一个参数 然后输出这个值
		//T 类型的名称标记
		public static void Test<T> ( T x ) {
			Console.WriteLine(x);
		}


		//T 表示的是类型 类型不同，类型的名称标记也就不同
		public static void Test<T1,T2,T3 > ( T1 x,T2 y , T3 z ) {
			Console.WriteLine(x+" : "+y+" : "+z);
		}


		static T2[] Test1<T1, T2, T3> ( T1 x , T2 y , T2[] z ) {
			return z;
		}
	}

	
}
