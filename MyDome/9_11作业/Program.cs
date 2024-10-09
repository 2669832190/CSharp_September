namespace _9_11作业 {
	internal class Program {
		static void Main(string[] args) {
            Console.WriteLine("欢迎使用图书馆借阅系统。\n\n");
			Stack stack = new Stack();
			Stack.maina(stack);
			for (; ; ) {
				stack.Print();
				Console.Write("请选择：1.借书，2.还书 ：");
				int num = int.Parse(Console.ReadLine());
				switch ( num ) {
					case 1:
						Feature feature = new Feature();
						Console.Write("请输入您要借阅的书名：");
						string name = Console.ReadLine();
						again:
						Console.Write("请选择输入您要借阅的天数（1-365）：");
						int days = int.Parse(Console.ReadLine());
						if ( days <= 0 || days > 365 ) {
                            Console.WriteLine("您输入的天数有误");
                            goto again;
						}
						Console.Write("请输入您要从哪天开始借阅（按照yyyy-mm-dd输入）：");
						string dateString = Console.ReadLine();
						DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
						feature.BorrowBook(name , days , date , stack);
						break;
					case 2:
						Feature feature1 = new Feature();
                        Console.Write("请输入要还的书名：");
						string name1 = Console.ReadLine();
						Console.Write("请输入您的还书日期（按照yyyy-mm-dd输入）：");
						string dateString1 = Console.ReadLine();
						DateTime date1 = DateTime.ParseExact(dateString1, "yyyy-MM-dd", System.Globalization.CultureInfo.CurrentCulture);
						feature1.ReturnBook(name1,date1,stack);
						break;
				}
				Console.ReadKey(true);
				Console.Clear();
			}
			//Console.WriteLine("Hello, World!");
		}
	}
}