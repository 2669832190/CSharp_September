namespace _9_9作业 {
	internal class Program {
		static void Main ( string[] args ) {
			Console.WriteLine("第一题：\n");
			T1();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("第二题：\n");
            T2();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("第三题：\n");
			T3();
			Console.ReadKey(true);
			Console.Clear();
			//
			Console.SetCursorPosition(50 , 10);
			Console.WriteLine("Hello, World!");
		}
		public static void T1 () {
			BattleBoss.maina();
		}
		public static void T2 () { 
			Wage.maina();
		}
		public static void T3 () {
			HardDisk.maina();
		}
	}
}
