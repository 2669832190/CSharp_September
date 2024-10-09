using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_10作业 {
	internal class ImitationList {
		public static void MyListH() { 
			MyList<int> myList = new MyList<int>();
			myList.Add(1);
			myList.Add(2);
			myList.Add(3);
			myList.Add(4);
			myList.Add(5);
			myList.Add(6);
			myList.Add(7);
			myList.Add(8);
			myList.Add(9);
			myList.Add(10);
			myList.Print();
            Console.WriteLine("长度："+myList.Count);
            Console.WriteLine("----------------------------------------------------------------");
            myList.Add(100);
			myList.Print();
			Console.WriteLine("加入“100”后的长度：" + myList.Count);
			Console.WriteLine("----------------------------------------------------------------");
			myList.Remove(100);
			myList.Print();
			Console.WriteLine("删除“100”后的长度：" + myList.Count);
			Console.WriteLine("----------------------------------------------------------------");
			myList.Print();
			Console.WriteLine("查询“6”是否存在：" + myList.Contains(6));
			Console.WriteLine("----------------------------------------------------------------");
			myList.Print();
			Console.WriteLine("查询“100”是否存在：" + myList.Contains(100));
			Console.WriteLine("----------------------------------------------------------------");
			myList.Clear();
            Console.WriteLine("清空数组后的长度为" + myList.Count);
			myList.Print();
		}
	}
	public class MyList<T> {
		public int Count { get; set; }
		public static int num { get; set; } = 1; 
		/// <summary>
		/// MyList
		/// </summary>
		T[] values = new T[0];
		#region 方法
		/// <summary>
		/// 添加元素
		/// </summary>
		/// <param name="value"></param>
		public void Add(T value) {
			Array.Resize(ref values , values.Length + 1);
			values[values.Length - 1] = value;
			Count = num;
			num++;
		}
		/// <summary>
		/// 删除元素
		/// </summary>
		/// <param name="value"></param>
		public void Remove(T value) {
			for ( int i = 0; i < num; i++ ) {
				if ( values[i].Equals(value) ) {
					Array.Copy(values,i+1,values,i,values.Length-i-1);
					Array.Resize(ref values , values.Length - 1);
					break;
				}
			}
			num-=2;
			Count = num;
			/*T[] valuestemp = new T[values.Length - 1];
			int index = 0;
			for ( int i = 0; i < values.Length; i++ ) {
				if ( !values[i].Equals(value) ) {
					valuestemp[index] = values[i];
					index++;
				}
			}
			values = valuestemp;
			Count = values.Length;*/
		}
		/// <summary>
		/// 查找是否存在
		/// </summary>
		/// <param name="value"></param>
		/// <returns>是或否</returns>
		public bool Contains(T value) {
			bool IsExist = false;
			foreach ( T t in values ) {
				if ( t.Equals(value) ) {
					IsExist = true; break;
				}
			}
			return IsExist;
		}
		/// <summary>
		/// 清除内容
		/// </summary>
		public void Clear() {
			T[] valuestemp = new T[0];
			values = valuestemp;
			Count = 0;
		}
		/// <summary>
		/// 遍历MyList
		/// </summary>
		public void Print() {
			Console.Write("遍历MyList：[");
			for ( int i = 0; i < Count; i++ ) {
				if ( i == Count - 1 ) {
					Console.Write(values[i]);
				} else {
					Console.Write(values[i] + " , ");
				}
			}
			Console.WriteLine("]");
		}
		#endregion
		/// <summary>
		/// 索引器
		/// </summary>
		public T this[int index] {
			get { return values[index];}
			set { values[index] = value;}
		}
	}
}
