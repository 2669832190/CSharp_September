using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10 {
	internal class 泛型约束 {
		public static void maina() {
			Print<int>(20);
			Print<string>("abc");
			Print<char>('a');
		}
		//泛型过于广泛 需要进行约束
		public static void Print<T>(T x) {
            Console.WriteLine(x);
        }
		//值类型约束 T只能为值类型
		public static void Print1<T>(T x) where T : struct {
            Console.WriteLine(x);
        }
		//引用类型约束
		public static void Print2<T>(T x) where T : class {
            Console.WriteLine(x);
        }
		//类 能够进行new() 的类型 必须拥有 无参构造函数
		public static void Print3<T>(T x) where T : new() {
            Console.WriteLine(x);
        }
		//只能是指定的类 或者 是其子类
		public static void Print4<T>(T x) where T : Animaltest {
            Console.WriteLine(x);
        }

		//只能是指定的接口 或者 实现了该接口的类
		public static void Print5<T>(T x) where T : Birdtest {
			Console.WriteLine(x);
		}

		//T的类型 必须是U的类型或者其子类
		public static void Print6<T,U>() where T : U {
			
		}

	}
	public class Animaltest { 
	
	}

	public interface Birdtest {
	
	}


}
