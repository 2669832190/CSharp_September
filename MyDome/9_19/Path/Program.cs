using System.IO;

namespace Path_ {
	internal class Program {
		static void Main(string[] args) {
			//Console.WriteLine("Hello, World!");
			string str = @"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt";

            //使用Path时，需要再在文档开头加：using System.IO;
            //Path显示某个文件的文件名（扩展名）及所在路径

			//文件名+扩展名
			Console.WriteLine(Path.GetFileName(str));

            //文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));

            //扩展名
            Console.WriteLine(Path.GetExtension(str));

            //路径信息（到文件夹目录）
            Console.WriteLine(Path.GetDirectoryName(str));

            //路径信息（全部路径，完整路径）
            Console.WriteLine(Path.GetFullPath(str));
        }
	}
}
