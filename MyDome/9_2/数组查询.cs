using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_2 {
	internal class 数组查询 {
		public static void maina () {
			//委托

			//封装（代理）一个函数 必须有布尔类型的返回值 有一个参数
			Predicate<int> pre = find;
			int[] arr = {5, 6, 7, 1, 2, 1, 4};

			//Array.Find -->查询与指定谓词匹配的第一个结果
			Console.WriteLine(Array.Find(arr , pre));
			//查找全部 需要注意的是返回的是一个数组，打印时需要进行遍历数组！！！
			//Array.FindAll(arr , findall);
			foreach ( int i in Array.FindAll(arr , findall) ) { Console.Write(i+" "); }
			//查找与条件匹配的第一个元素后返回索引
			Array.FindIndex(arr , x => x == 1);
			//查找与条件匹配的最后一个元素后返回元素值
			Array.FindLast(arr , x => x == 1);
			//查找与条件相匹配的最后一个元素后返回先对应的索引
			Array.FindLastIndex(arr , x => x == 1);
			a();
        }
		public static bool find (int x) {
			return x < 3;
		}
		public static bool findall ( int x ) {
			return x < 3;
		}



		public static void a () {
			Random random = new Random();
			int[] arr = new int[random.Next(10,16)];
			for ( int i = 0; i < arr.Length; i++ ) { 
				arr[i] = random.Next(1,11);
			}
			foreach ( int x in arr ) { Console.Write( x + " " ); }
            Console.WriteLine();
            Console.WriteLine(Array.Find(arr , x => x > 5));
			//查找全部时，返回值为数组，需要打印时进行遍历！！！
			//Console.WriteLine(Array.FindAll (arr,x=> x>2));
			foreach ( int item in Array.FindAll(arr , x => x > 2) ) { Console.Write(item + " "); }Console.WriteLine();
            Console.WriteLine(Array.FindIndex(arr,x=>x>7));
            Console.WriteLine(Array.FindLast(arr,x=>x>1));
            Console.WriteLine(Array.FindLastIndex(arr,x=> x>1));

			//数组遍历
			Array.ForEach(arr , x => Console.WriteLine(x + " "));

			//
        }

	}
}
