using System.Text;

namespace File操作文档内容 {
	internal class Program {
		static void Main(string[] args) {
			//Console.WriteLine("");
			//File.Create(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt");
			string str = "Hello, World!";
			//将字符串转为字节数组
			//Encoding.Default 默认字符编码
			//.GetBytes(str) 将 str 转为对应编码的字节数组
			byte[] bytes = Encoding.Default.GetBytes(str);
			//将字节数组 写入 H:\CSharp_September\C#文件类的操作_temp\newtemp.txt 的文件中
			File.WriteAllBytes(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt",bytes);

			//读取文件将 H:\CSharp_September\C#文件类的操作_temp\newtemp.txt 里面的字节存入字节数组 read 中
			byte[] read = File.ReadAllBytes(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt");
			//将字节数组转为 字符串类型 便于打印读取
			string readStr = Encoding.Default.GetString(read);
			//输出转换完成的字符串
            Console.WriteLine(readStr);

			//byte 字节 既是数据类型也是内存单位
			//1byte = 8bit		1字节 = 8位
			//1kb = 1024byte
			//1mb = 1024kb
			//1gb = 1024mb
			//1tb = 1024gb
			//1pb = 1024tb EB ZB YB ......
        }
	}
}
