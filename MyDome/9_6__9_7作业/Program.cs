namespace _9_6__9_7作业 {
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
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("第三题：\n");
			T3();
			Console.ReadKey(true);
			Console.Clear();
			Console.SetCursorPosition( 50, 10 );
			Console.WriteLine("Hello, World!\n");
		}


		#region 每一题的入口
		public static void T1 () {
			#region 创建对象
			Student student1 = new Student("张三",18,89.5,87.5,85);
			Student student2 = new Student("李四",19,98,86.5,87.5);
			Student student3 = new Student("王五",18,76.5,77.5,82.5);
			Student student4 = new Student("小红",17,96,94,95.5);
			Student student5 = new Student("小明",18,78.5,88.5,75);
			Student student6 = new Student("小刚",19,87.5,95.5,95);
			#endregion
			#region 添加对象到集合
			List<Student> students = new List<Student> ();
			students.Add(student1);
			students.Add(student2);
			students.Add(student3);
			students.Add(student4);
			students.Add(student5);
			students.Add(student6);
			#endregion
			Console.WriteLine("按照总分进行排序输出：\n");
			Student.SumGradePrintf(students);
            Console.WriteLine("--------------------------------------------------------------------");
			Console.WriteLine("高于平均分的学生有：\n");
			Student.HeightAverageGradePrintf(students);
		}
		public static void T2 () {
			Card.PrintfOverPoints(Card.DealCardsAndSort(Card.Assign()));
		}
		public static void T3 () {
			//结构体
			//BeatMonster.Generate();
			//类
			BattleBoss battleBoss = new BattleBoss();
		}
		#endregion
	}
}
