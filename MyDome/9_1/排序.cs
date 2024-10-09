using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1 {
	internal class 排序 {
		public static void maina () {
			int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14};
			//Sort();
			//Array.Sort(ints);
			
			
			//封装一个方法 int类型的返回值 有两个参数
			//Comparison
			Array.Sort(ints,(x,y)=>x-y);
			Array.ForEach(ints , x => Console.WriteLine(x + " "));
			Array.Sort(ints,(x,y)=>y-x);
			Array.ForEach(ints , x => Console.WriteLine(x + " "));
			a();
		}

		public static void a () {
			Random random = new Random();
			int[] arr = new int[random.Next(10,16)];
			for ( int i = 0; i < arr.Length; i++ ) {
				arr[i] = random.Next(1,51);
			}
            Console.Write("[");
            Array.ForEach(arr,x=>Console.Write(x+" "));
            Console.WriteLine("]");
            //升序
            Array.Sort(arr , ( x , y ) => x - y);
            Console.Write("[");
            Array.ForEach(arr , x => Console.Write(x + " ")); 
            Console.WriteLine("]");
            //降序
            Console.Write("[");
            Array.Sort(arr , ( x , y ) => y - x);
			Array.ForEach(arr , x => Console.Write(x + " "));
			Console.WriteLine("]");

		}
	}
}
