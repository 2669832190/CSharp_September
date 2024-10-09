//using System.IO;
using System.Text;

namespace 字节流 {
	internal class Program {
		static void Main(string[] args) {

			//流：一组连续的数据 动态的写入或读出
			//字节流：以字节的方式
			//
			#region 读

			//1.创建字节流
			FileStream fs = new FileStream("./new.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
			//2.创建一个字节数组 用于读写 我们叫做 缓存区
			byte[] buffer = new byte[1024 * 5];
			//3.读内容
			//保存到哪去		从哪开始读	读多少个字节
			//返回int类型 表示成功读取到多少字节
			int num = fs.Read(buffer, 0, buffer.Length);

			string str = Encoding.UTF8.GetString(buffer,0,num);
            Console.WriteLine(str);

			//4.释放内存
			fs.Close();
			fs.Dispose();

			//语法糖 (可以省去释放内存)
			/*
			using ( FileStream fs2 = new FileStream("./new.txt" , FileMode.OpenOrCreate , FileAccess.ReadWrite) ) {
				//2.创建一个字节数组 用于读写 我们叫做 缓存区
				byte[] buffer2 = new byte[1024 * 5];
				//3.读内容
				//保存到哪去		从哪开始读	读多少个字节
				//返回int类型 表示成功读取到多少字节
				int num2 = fs2.Read(buffer2, 0, buffer2.Length);

				string str2 = Encoding.UTF8.GetString(buffer2,0,num);
				Console.WriteLine(str2);
			}
			*/
			#endregion

			#region 写

			using (FileStream fs1 = new FileStream("./new.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite)) {
				string str1 = "qwertyuiopasdfghjklzxcvbnm";
				byte[] bytes = Encoding.UTF8.GetBytes(str1);
				fs1.Write(bytes, 0, bytes.Length);
			}

			#endregion


			//Console.WriteLine("Hello, World!");
		}



		/// <summary>
		/// 复习1：字节读写文件
		/// </summary>
		private static void review1() {
			//以字节的形式读写
			//好处：字节是内存单位 能读写所有类型的文件
			//坏处：

			string str = "abcdefg";
			byte[] bytes = Encoding.Default.GetBytes(str);

			//写文件
			//File.WriteAllBytes("./new.txt",bytes);

			//读文件
			byte[] read = File.ReadAllBytes("./new.txt");
			//转字符串方便输出
			string readstr = Encoding.Default.GetString(read);
			Console.WriteLine(readstr);

		}
		/// <summary>
		/// 复习2：字符串读写文本文件
		/// </summary>
		private static void review2() {
			
			//写入字符串
			File.WriteAllText("./new.txt","123456");


			//一行一行写入整个字符串数组
			string[] strings = { 
				"张三",
				"李四",
				"王五"
			};
			File.WriteAllLines("./new.txt",strings);

			//全部读到一个字符串
		}
	}
}
