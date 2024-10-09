namespace _9_19 {
	internal class File类操作 {
		static void Main(string[] args) {
			Console.WriteLine("Hello, World!");
			//当程序中的语句中包含此路径下的相同文件时会出现文件已被打开的报错，所以 以下的每一句代码都只能一句一句的实现功能！！！
			//@ 忽略转义字符
			//File.Create(路径)；创建或覆盖
			//File.Create(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt");
			//File.Create("H:\\CSharp_September\\C#文件类的操作_temp\\newtemp1.txt");


			//File.Delete(路径)；删除
			//File.Delete(@"H:\CSharp_September\C#文件类的操作_temp\newtemp1.txt");


			//File.Copy(原路径 , 新路径)；复制（新路径下不能有同名文件，不能复制文件夹）
			//File.Copy(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt", @"H:\CSharp_September\C#文件类的操作_temp\复制或移动后的文件\newtemp.txt");


			//File.Move(原路径，新路径)；移动（可以对移动后的文件名进行修改）
			//File.Move(@"H:\CSharp_September\C#文件类的操作_temp\newtemp.txt" , @"H:\CSharp_September\C#文件类的操作_temp\复制或移动后的文件\newtemp1.txt");
		}
	}
}
