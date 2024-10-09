using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace _9_1 {
	internal class lambda表达式 {

		public static void maina () {
			//lambda表达式 拉姆达表达式
			//=> 前端 箭头函数	
			//没有名字 匿名函数
			#region 没有参数的情况
			/*static void act () {
                Console.WriteLine("Hello");
            }*/
			Action act = () => { Console.WriteLine("Hello"); };
			act();
			#endregion

			#region 有一个参数的情况
			//当参数只有一个的时候 可以不要小括号，直接将参数变量名写在括号的位置即可
			//数据类型可以省略
			//代码体里只有一行代码的时候，大括号也可以不要
			/*static void act2 (int x) {
                Console.WriteLine("x的值是："+ x );
            }*/
			//Action<int> act2 =(int x) => { Console.WriteLine("x的值是：" + x); };
			Action<int> act2 = x => Console.WriteLine("x的值是：" + x);
			act2(10);

			#endregion

			#region 有两个参数的情况
			/*static void act3 (int x,int y) {
                Console.WriteLine(x + "+" + y + "的值是：" + ( x + y ));
            }*/
			Action<int,int> act3 = ( x , y ) => Console.WriteLine(x+"+"+y+"的值是：" + (x+y));
			act3(10,20);
			#endregion

			#region 有返回值的情况
			
			/*static int fun1 (int x,int y) {
				return x + y;
			}*/
			Func<int,int,int> fun1 = (x,y) =>x+y;
            Console.WriteLine(fun1(1,2));

			/*static int fun2 (string str) { 
				return str.Length;
			}*/
			Func<string,int> fun2 = (str) => str.Length;
            Console.WriteLine(fun2("abcde"));
			#endregion

			#region 稍微复杂一点
			//输入一个数字 返回是不是偶数
			/*static bool fun3 (int x) {
				if ( x % 2 == 0 ) {
					return true;
				} else {
					return false;
				}
			}*/
			Func<int,bool> fun3 = (x)=>{
				if ( x % 2 == 0 ) {
					return true;
				} else {
					return false;
				}
			};
            Console.WriteLine(fun3(10));
            #endregion

        }
	}
}
