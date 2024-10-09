namespace _9_12作业 {
	internal class Program {
		static void Main(string[] args) {
            Console.WriteLine("第一题：");
            T1();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("第二题：");
			T2();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("第三题：");
			T3();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("第四题：");
			T4();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("第五题：");
			T5();
			Console.ReadKey(true);
			Console.Clear();
			Console.WriteLine("Hello, World!");
		}
		#region 第一题
		public static void T1() {
			int Count = 0;
			Console.Write("请输入糖果个数：");
			int num = int.Parse(Console.ReadLine());
			Saccharide(num , Count);
		}
		public static void Saccharide(int num , int Count) {
			if ( Count > 4 ) {
				return;
			} else {
				Console.Write("第" + ( Count + 1 ) + "小朋友有" + num / 3 + "个糖果。\n");
				num -= num / 3 + num % 3;
				Count++;
				Saccharide(num , Count);
			}
		}
		#endregion
		#region 第二题
		public static void T2() {
			Console.Write("请输入饼干的个数：");
			int Num = int.Parse(Console.ReadLine());
			Console.Write("请输入小朋友的人数：");
			int Peoplenum = int.Parse(Console.ReadLine());
            Console.WriteLine(Num+"块饼干给"+Peoplenum+"个小朋友分够分？"+ShareCookies(Num,Peoplenum));
        }
		public static bool ShareCookies(int Num , int Peoplenum) {
			int[] arr = new int[Peoplenum];
			int sum = 0;
			for ( int i = 0,num = 0; i < arr.Length; i++ ) {
				arr[i] = ++num;
				sum += arr[i];
			}
			return sum <= Num ? true : false;
		}
		#endregion
		#region 第三题
		public static void T3() {
            Console.Write("请输入灯的数量（即人的数量）：");
			int num = int.Parse(Console.ReadLine());
			int[] arr = new int[num];
			int index = 1;
			for ( int i = 0; i < arr.Length; i++ ) {
				arr[i] = 0;
			}
			TurnOnLight(index , arr);
            Console.WriteLine("还有 "+TurnOnLightNum(arr)+" 灯是开着的！");
        }
		public static void TurnOnLight(int index,int[] arr) {
			for ( int i = 0,j = 1; i < arr.Length; i++,j++ ) {
				if ( j % index == 0 ) {
					if ( arr[i] == 0 ) {
						arr[i] = 1;
					} else {
						arr[i] = 0;
					}
				}
			}
			index++;
			if ( index <= arr.Length ) {
				TurnOnLight(index , arr);
			} else {
				return;
			}
		}
		public static int TurnOnLightNum(int[] arr) {
			int num = 0;
			for ( int i = 0; i < arr.Length; i++ ) {
				if ( arr[i] == 1 ) {
					num++;
				}
			}
			return num;
		}
		#endregion
		#region 第四题
		public static void T4() {
            Console.Write("请输入一个字符串：");
			string str = Console.ReadLine();
			char[] arr = str.ToCharArray();
			List<char> strarr = new List<char>();
			for ( int i = 0; i < arr.Length; i++ ) {
				strarr.Add(arr[i]);
			}
            Console.WriteLine(Turn(strarr) == ' ' ? "字符串"+str+"中无第一次出现一次的字符！" 
				: "字符串："+str+"中第一次出现一次的字符为："+Turn(strarr));
        }
		public static char Turn(List<char> strarr) {
			for ( int i = 0; i < strarr.Count; i++ ) {
				if ( strarr.IndexOf(strarr[i]) == strarr.LastIndexOf(strarr[i]) ) {
					return strarr[i];
                }
			}
			return ' ';
		}
		#endregion
		#region 第五题
		public static void T5() {
            Console.Write("请输入小时：");
			int h = int.Parse(Console.ReadLine());
			Console.Write("请输入分钟：");
			int m = int.Parse(Console.ReadLine());
			Console.Write("请输入秒：");
			int s = int.Parse(Console.ReadLine());
			Console.Write("请输入学习时间（秒）：");
			int s1 = int.Parse(Console.ReadLine());
			DateTime dateTime = new DateTime(1,1,1,h,m,s);
			dateTime = dateTime.AddSeconds(s1);
            Console.WriteLine("您将在"+dateTime.ToString("hh时mm分ss秒")+"休息");
        }
		#endregion
	}
}