using System.Text.RegularExpressions;

namespace IsIp {
	internal class Program {
		static void Main(string[] args) {
			//(^((2[0-4]\d.)|(25[0-5].)|(1\d{2}.)|(\d{1,2}.))((2[0-5]{2}.)|(1\d{2}.)|(\d{1,2}.){2})((1\d{2})|(2[0-5]{2})|(\d{1,2})))
			Regex regex = new Regex(@"(^((2[0-4]\d.)|(25[0-5].)|(1\d{2}.)|(\d{1,2}.))((2[0-5]{2}.)|(1\d{2}.)|(\d{1,2}.){2})((1\d{2})|(2[0-5]{2})|(\d{1,2})))");
			Console.Write("请输入一个IP地址：");
			string Ip = Console.ReadLine();
			if ( regex.IsMatch(Ip) ) {
				Console.WriteLine("true");
			} else {
				Console.WriteLine("false");
			}
			Console.WriteLine("Hello, World!");
		}
	}
}
