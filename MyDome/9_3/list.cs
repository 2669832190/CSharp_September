using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3 {
	internal class list {
		public static void maina () {
			//动态数组
			//长度不固定 能够储存任意类型
			//ArrayList list = new ArrayList ();

			//list
			//长度不固定 只能保存相同的类型
			//不需要装箱拆箱 所以速度更快
			List<string> list = new List<string>();
			list.Add("1");
			list.Add("2");

			List<int> list2 = new List<int>();
			list2.Add(123);
			list2.Add(456);

			List<char> chars = new List<char>(){ 'a','b','c'};
			//获取list保存的元素的数量
            Console.WriteLine(chars.Count);
			//访问其中的元素
			Console.WriteLine(chars[2]);
			//删除指定内容
			chars.Remove('b');
			//删除指定索引
			chars.RemoveAt(0);
			a();
        }
		public static void a () { 
			List<char> listchar = new List<char>(){ 'a','b','c','d','e','f','g','h','i'};
            Console.Write("原集合为：");
            parint(listchar);
            Console.WriteLine();
            Console.Write("添加’j‘元素后集合为：");
            listchar.Add('j');
			parint(listchar);
            Console.WriteLine();
            //list长度
            Console.WriteLine("集合的长度："+ listchar.Count);//10
            //删除指定元素‘j’
            Console.WriteLine();
            Console.Write("删除’j‘元素后的集合为：");
            listchar.Remove('j');
			parint(listchar);
            //指定索引删除
            Console.WriteLine();
            Console.Write("删除0号索引值后的集合为：");
            listchar.RemoveAt(0);
			parint(listchar);
            //颠倒
            Console.WriteLine();
            Console.Write("颠倒集合后集合为：");
            listchar.Reverse();
			parint(listchar);
            //查询对应值的索引
            Console.WriteLine();
            listchar.Reverse();
            //
            Console.Write("反转回来后的集合为：");
            parint(listchar);
            Console.WriteLine();
			Console.Write("查询对应值的索引 --->");
			Console.WriteLine("查询到c的索引值为："+listchar.IndexOf('c'));
            //查询值是否存在
            Console.WriteLine();
            Console.Write("查询：");
            parint(listchar);
            Console.WriteLine();
			Console.Write("查询以上集合中，某个值是否存在 --->");
			Console.WriteLine("查询’e‘是否存在于集合中："+listchar.Contains('e'));
        }
		public static void parint ( List<char> listchar ) { 
			foreach ( char c in listchar ) { Console.Write(c +" "); } Console.WriteLine();
		}
	}
}
