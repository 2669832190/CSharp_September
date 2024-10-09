using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1 {
	internal class 三元表达式和异常捕获 {
		public static void maina () {
            //异常捕获
            //1.
            Console.WriteLine("异常捕获:");
            try {
				//需要进行异常捕获的代码，当出现异常时进入catch语句块
				//当一个异常发生时，会终止程序的运行，导致后续代码无法执行
				Console.WriteLine("例1（通过确定异常进行捕获输出不同的异常情况）：");
				Console.WriteLine("请输入数字：");
				int a = int.Parse( Console.ReadLine() );
				int num = 10 / a;
				Console.WriteLine("输入的值为：" + a);
			} catch ( FormatException e ) {
				//当出现异常时执行的代码，不出现异常时不运行。
				Console.WriteLine("输入格式有误，触发格式异常！");
			} catch ( DivideByZeroException e ) {
				Console.WriteLine("发生了异常！尝试除以 0 ");
			}
			//2.
			try {
				Console.WriteLine("例2（通过异常基类 Exception 进行捕获所有异常，阻断程序的运行并反馈出现异常）：");
				Console.WriteLine("请输入数字：");
				int a = int.Parse( Console.ReadLine() );
				int num = 10 / a;
				Console.WriteLine("输入的值为：" + a);
			} catch ( Exception e ) {
				//Exception --->是所有异常的基类（父类）能捕获所有异常
				//Console.WriteLine(e.Message);
				Console.WriteLine("发生异常（通过异常基类进行捕获）");

			}
			//3.
			try {
				Console.WriteLine("例3（通过不加异常括号，进行捕获所有异常，阻断程序的运行并反馈出现异常）：");
				Console.WriteLine("请输入数字：");
				int a = int.Parse( Console.ReadLine() );
				int num = 10 / a;
				Console.WriteLine("输入的值为：" + a);
			} catch {
				//不写括号也能捕获所有的异常！
				Console.WriteLine("发生异常（通过不加异常括号捕获所有异常）");
			}

			//三元表达式的嵌套
			//	条件1 ？ 条件2 ？条件3 ？ 全部为true : 条件3为false走这里 : 条件2为false走这里 : 条件1为false走这里 ; 
			//当三个条件全为true时，直接进入全部为true里
			//当其中不管哪一个条件为false时，进入false的语句后直接阻止后续的条件判断（套娃）
            Console.WriteLine("三元表达式的嵌套:");
			int x = 10;
			int y = x < 50 ? x < 10 ? x < 5 ? 3 : 4 : ++x : x--;
			Console.WriteLine(y);//11
		}
	}
}
