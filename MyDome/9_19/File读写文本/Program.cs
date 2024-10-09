namespace File读写文本 {
	internal class Program {
		static void Main(string[] args) {
			//Console.WriteLine("Hello, World!");
			/*string[] strs = { 
				"张三",
				"李四",
				"王五"
			};*/
			//会覆盖原来的文件，原来文件中的文本将丢失
			//File.WriteAllLines(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt" , strs);

			//覆盖写入一行字符串
			//File.WriteAllText(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt" , "坤坤");

			
			//追加字符串，不覆盖
			//File.AppendAllText(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt" , "坤坤");



			//读
			//一行一行的读到一个字符串数组里
/*			string[] strss = File.ReadAllLines(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt");
			foreach ( string str in strss ) {
                Console.WriteLine(str);
            }
*/
			//全部读到一起
			string newStr = File.ReadAllText(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt");
            Console.WriteLine(newStr);
		}
	}
}
