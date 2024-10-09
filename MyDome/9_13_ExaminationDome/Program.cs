namespace _9_13_ExaminationDome {
	internal class Program {
		static void Main(string[] args) {
			Car car = new Car();
			List<CarMessage> Cars = car.CarMessages();
			Feature feature = new Feature();
			while ( true ) {
				Console.SetCursorPosition(50 , 2);
                Console.WriteLine("欢迎光临桓桓汽车租赁公司\n\n");
				feature.print(Cars);
                Console.WriteLine();
                Console.Write("请输入数字确定您想要使用的功能（1.添加汽车信息，2.删除汽车，3.租车，4.还车，5.退出系统）：");
				try {
					int num = int.Parse(Console.ReadLine());
					switch ( num ) {
						case 1:
							feature.AddCat(Cars);
                            Console.ReadKey(true);
                            Console.Clear();
							break;
						case 2:
							feature.RemoveCat(Cars);
                            Console.ReadKey(true);
							Console.Clear();
							break;
						case 3:
							feature.RentCat(Cars);
                            Console.ReadKey(true);
							Console.Clear();
							break;
						case 4:
							feature.ReturnCat(Cars);
                            Console.ReadKey(true);
							Console.Clear();
							break;
						case 5:
							return;

					}
				} catch ( Exception ) {
					Console.WriteLine("您输入的信息不合法！！！\n请重新进行输入！");
					Console.ReadKey(true);
					Console.Clear();
				}
			}
		}
	}
}