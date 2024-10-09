using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1 {
	internal class 动态数组 {
		public static void maina() {
            Console.WriteLine("动态数组（集合）:");
			//我们之前用到的数组声明时必须声明长度
			int[] ints = new int[10];

			//动态数组在存储的过程中 进行了装箱操作
			ArrayList list = new ArrayList(){
				1,
				"123",
				true,
				'a',
				2.5,
				new int[] {1,2,3,4 }
			};
			//取出来的时候需要进行拆箱
			int i = (int)list[0];
			string str = (string)list[1];

            //add添加
			list.Add(20);
            //.Count获取长度
            Console.WriteLine(list.Count);
            //删除（指定内容删除）
            list.Remove(2.5);
            Console.WriteLine(list.Count);
            //删除（指定位置删除）
            list.RemoveAt(2);
			Console.WriteLine(list[2]);
			//颠倒数组
			list.Reverse();
			Console.WriteLine(list[2]);
            //查询对应值的索引
            Console.WriteLine(list.IndexOf("123"));
            //查询值是否存在
            Console.WriteLine(list.Contains(20));
			a();
        }
		public static void a () {
			ArrayList list = new ArrayList(){
				1,
				"123",
				true,
				'a',
				2.5,
				new int[] {1,2,3,4 }
			};
			for ( int i = 0; i < list.Count; i++ ) {
                Console.Write(list[i]+"\n");
				
			}
		}
	}
}
