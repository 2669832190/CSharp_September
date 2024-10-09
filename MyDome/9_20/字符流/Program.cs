using System.Text;

namespace 字符流 {
	internal class Program {
		static void Main(string[] args) {

			//1.创建读的字符流
			//方便 但是只能读文本
			using (StreamReader sr = new StreamReader("./new.txt",Encoding.UTF8)) {
                //读到结尾	sr.ReadToEnd();
                Console.WriteLine(sr.ReadToEnd());

                //读一行
                Console.WriteLine(sr.ReadLine());

				//读取全部 (获取sr判断是否是最后一行)
				while ( !sr.EndOfStream ) { 
	                Console.WriteLine(sr.ReadLine());
				}
			}

			//写文本 (true追加，false覆盖)
			using (StreamWriter sw = new StreamWriter("./new.txt",true)) {
				sw.Write("ABCDEFG");
			}


			//Console.WriteLine("Hello, World!");
		}
	}
}
