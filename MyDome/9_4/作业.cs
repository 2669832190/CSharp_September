using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4 {
	internal class 作业 {
		public static void maina () {
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("第一题：");
			Console.ForegroundColor = ConsoleColor.Green;
			T1();
			Console.ReadKey(true);
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("第二题：");
			Console.ForegroundColor = ConsoleColor.Green;
			T2();
			//T2_1();
			Console.ReadKey(true);
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("第三题：");
			Console.ForegroundColor = ConsoleColor.Green;
			T3();
			Console.ReadKey(true);
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("第四题：");
			Console.ForegroundColor = ConsoleColor.Green;
			T4("abacbdncabcadbc");
			Console.ReadKey(true);
			Console.Clear();
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("第五题：");
			Console.ForegroundColor = ConsoleColor.Green;
			T5();
			Console.ReadKey(true);
		}
		#region 第一题方法入口
		/*1. 写一个Ticket类，表示车票
			有一个路程字段（不能为负数）
			有一个计算价格方法，计算方式如下：
			每公里1元
			0-100公里，票价为原价
			101-200公里，票价打9.5折
			201-300公里，票价打9折
			300公里以上，票价打8折
			输入一个公里数，输出需要付多少钱。
		*/
		public static void T1 () {
			Ticket ticket = new Ticket();
			Console.SetWindowSize(100 , 50);
			Console.SetCursorPosition(38 , 2);
			Console.WriteLine("！！！欢迎乘坐黑车！！！");
			Console.SetCursorPosition(45 , 5);
			Console.WriteLine("服务费50元");
			Console.SetCursorPosition(23 , 7);
			Console.WriteLine("不足一公里按一公里计算，同时不足一块钱的部分按一块钱！");
			Console.SetCursorPosition(22 , 9);
			Console.WriteLine("公里数大于一百时收取10元长途费，每增加100公里增加10元！");
			Console.SetCursorPosition(34 , 11);
			Console.WriteLine("车费总额为里程费+服务费+长途费！");
			Console.SetCursorPosition(10 , 13);
			Console.Write("请输入一个公里数：");
			double kilometres = double.Parse(Console.ReadLine());
			ticket.Path = kilometres;
			Console.SetCursorPosition(26 , 15);
			Console.WriteLine("感谢您的乘坐，您一共乘坐"+ kilometres + "KM，共支付" + ticket.Price() + "元车费。");
			Console.SetCursorPosition(36 , 16);
			Console.WriteLine("！！！欢迎您的下次乘坐！！！");
        }
		#endregion

		#region 第二题方法入口
		/*
		 2. 写一个Dog类，表示狗
			拥有这些字段：名字，性别，年龄
			性别只能有公和母
			年龄在0-20之间
		 */
		public static void T2 () {
			Dog dog = new Dog();
			dog.Name = "糖豆";
			dog.Sex = "公";
			dog.Age = 2;
			dog.parint();
		}
		public static void T2_1 () {
			Dog dog = new Dog();
            Console.WriteLine("请输入Dog的名字：");
			string name = Console.ReadLine();
            dog.Name = name;
			again:
            Console.WriteLine("请输入Dog的性别（公，母）：");
			string Sex = Console.ReadLine();
			if ( Sex == "公" || Sex == "母" ) {
				dog.Sex = Sex;
			} else {
				goto again;
			}
			again1:
            Console.WriteLine("请输入Dog的年龄（0-20）：");
			int age = int.Parse(Console.ReadLine());
			if ( age <= 20 && age >= 0 ) {
				dog.Age = age;
			} else {
				goto again1;
			}
			dog.parint();
		}
		#endregion

		#region 第三题方法入口
		//3. 输入一行字符，分别统计出其中 英文字母、 数字 和 其它字符 的个数
		public static void T3 () {
            Console.Write("请输入一行字符：");
			string str = Console.ReadLine();
			Num num = new Num();
			num.str(str);
        }
		#endregion

		#region 第四题方法入口
		public static void T4 ( string str ) {
			char[] chars = str.ToCharArray();
			Dictionary<char,int> charsnum = new Dictionary<char,int>();
			for ( int i = 0; i < chars.Length; i++ ) {
				if ( charsnum.ContainsKey(chars[i]) ) {
					charsnum[chars[i]]++;
				} else {
					charsnum.Add(chars[i] , 1);
				}
			}
            Console.WriteLine("字符"+str+"中各个字符的数量如下：");
            foreach ( var item in charsnum ) {
				Console.Write(item.Key + " ：" + item.Value +"\t");
			}
		}
		#endregion

		#region 第五题方法入口
		/*
			5. 打扑克
			大王 小王 k q j 10 9 8 7 6 5 4 3 2 A
			在控制台 随机发牌 三个人每人一个数组
			最终输出每个人的牌
		*/
		public static void T5 () { 
			Cards cards = new Cards();
			int[][] ints = cards.Card();
			cards.print(cards.Player(ints));
		}
		#endregion
	}

	#region Ticket
	/// <summary>
	/// 车费
	/// </summary>
	public class Ticket {
		private double _path;
		public double Path {
			get {
				return _path;
			}
			set {
				//判断输入的公里数是否合法
				if ( value >= 0 ) {
					_path = value;
				} else {
					Console.WriteLine("公里数不合法！！！");
				}
			}
		}
		/// <summary>
		/// 计算车费
		/// </summary>
		/// <returns>车费的总和，公里数+服务费+长途费</returns>
		public int Price () {
			int service = 50;
			int Longdistance = 10;
			double pricenumInception = 0;
			int price = 0;
			if ( _path > 0 && _path <= 100 ) {
				pricenumInception = _path;
				price = (int)pricenumInception + 1 + service;
			} else if ( _path > 100 && _path <= 200 ) {
				pricenumInception = _path * 0.95;
				price = (int)pricenumInception + 1 + service + Longdistance;
			} else if ( _path > 200 && _path <= 300 ) {
				pricenumInception = _path * 0.9;
				price = (int)pricenumInception + 1 + service + Longdistance * 2;
			} else {
				pricenumInception = _path * 0.8;
				price = (int)pricenumInception + 1 + service + Longdistance * 3;
			}
			return price;
		}
	}
	#endregion

	#region Dog
	public class Dog { 
		private string _name;
		private string _sex;
		private int _age;

		public string Name {
			get { 
				return _name;
			}set {
				if ( IsNotName(value) ) {
					_name = value;
				} else {
                    Console.WriteLine("输入的姓名不合法！！！");
                }
			}
		}
		/// <summary>
		/// 判断名字中是否含有数字
		/// </summary>
		/// <param name="str">传入的时dog_name</param>
		/// <returns>true继续执行，false姓名不合法</returns>
		public static bool IsNotName ( string str ) {
			bool Isnotname = true;
			char[] chars = str.ToCharArray();
			for ( int i = 0; i < chars.Length; i++ ) {
				if ( chars[i] >= 48 && chars[i] <= 57 ) {
					Isnotname = false;
				}
			}
			return Isnotname;
		}

		public string Sex {
			get {
				return _sex;
			}
			set {
				if ( value == "公"|| value == "母" ) {
					_sex = value;
				} else {
					Console.WriteLine("输入的性别不合法！！！");
				}
			}
		}

		public int Age {
			get {
				return _age;
			}set {
				if ( value >= 0 && value <= 20 ) {
					_age = value;
				} else {
                    Console.WriteLine("输入的年龄不合法！！！");
                }
			}
		}
		//输出
		public void parint () {
            Console.WriteLine("这只Dog的名字为："+_name+",性别为："+_sex+",年龄为："+_age+"岁。");
        }
	}
	#endregion

	#region Num
	public class Num { 
		private int _nNum;
		private int _eNum;
		private int _oNum;
		public int Nnum {
			get {
				return _nNum;
			}set { 
				_nNum = value;
			}
		}
		public int Ennum {
			get {
				return _eNum;
			}
			set {
				_eNum = value;
			}
		}
		public int Onum {
			get {
				return _oNum;
			}
			set {
				_oNum = value;
			}
		}

		public void str (string str) {
			int nnum = 0;
			int ennum = 0;
			int sum = str.Length;
			char[] chars = str.ToCharArray ();
			for ( int i = 0; i < chars.Length; i++ ) {
				if ( chars[i] >= '0' && chars[i] <= '9' ) { 
					nnum++;
				}else if ( (chars[i] >= 'A' && chars[i] <='Z') || (chars[i] >= 'a' && chars[i] <= 'z') ) {
					ennum++;
				}
			}
			int onum = sum - nnum - ennum;
			Num num = new Num();
			num.Nnum = nnum;
			num.Ennum = ennum;
			num.Onum = onum;
            Console.WriteLine(str+"这个字符串中包含英文字母：" + num.Ennum +"个，数字字符：" + num.Nnum +"个，其他字符：" + num.Onum + "个。");
        }
	}
	#endregion

	#region Cards
	public class Cards {
		public int[] RHeart;
		public int[] RDiamond;
		public int[] BSpade;
		public int[] BClub;
		public int[] Jokers;

		/// <summary>
		/// 做出扑克牌
		/// </summary>
		/// <returns>返回一个以1-13的数字牌以及0，1的大小王，为发牌做准备</returns>
		public int[][] Card () {
			int[][] CardsAll = new int[][]{
				RHeart = new int[13],
				RDiamond = new int[13],
				BSpade = new int[13],
				BClub = new int[13],
				Jokers = new int[]{ 0,1}
			};
			for ( int i = 0; i < CardsAll.Length; i++ ) {
				for ( int j = 0; j < CardsAll[i].Length; j++ ) {
					CardsAll[i][j] = j + 1;
				}
			}
			return CardsAll;
		}
		/// <summary>
		/// 发牌时并改变牌面的值
		/// </summary>
		/// <param name="Card">传入int_Card</param>
		/// <returns>每次发一张牌并将int转为对应的牌面值</returns>
		public string Deal ( int[][] Card ) {
			string str =null;
		again:
			Random rand = new Random();
			int anum = rand.Next(0, 5);
			int Num = rand.Next(0,13);
			int num = rand.Next(0,2);
			if ( anum == 4 ) {
				if ( Card[anum][num] != -1 ) {
					str = Card[anum][num].ToString();
					if ( str == "0" ) {
						str = "Joker";
					} else {
						str = "joker";
					}
					Card[anum][num] = -1;
				} else {
					goto again;
				}
			} else {
				if ( Card[anum][Num] != -1 ) {
					str = Card[anum][Num].ToString();
					switch ( str ) {
						case "1":
							str = "A";
							break;
						case "11":
							str = "J";
							break;
						case "12":
							str = "Q";
							break;
						case "13":
							str = "K";
							break;
					}
					Card[anum][Num] = -1;
				} else {
					goto again;
				}
			}

			return str;
		}

		//------------------------
		//玩家
		public string[] player1;
		public string[] player2;
		public string[] player3;
		/// <summary>
		/// 
		/// </summary>
		/// <param name="Card">传入int_Card后续进行发牌并改变值</param>
		/// <returns>返回一个交错数组，里面包含三个玩家手中的牌，为后续输出做准备</returns>
		public string[][] Player ( int[][] Card ) {
			string[][] players = {
				player1 = new string[20],
				player2 = new string[17],
				player3 = new string[17]
			};


			for ( int i = 0; i < players.Length; i++ ) {
				for ( int j = 0; j < players[i].Length; j++ ) {
					players[i][j] = Deal(Card);
				}
			}
			return players;
		}

		/// <summary>
		/// 打印三个玩家手中的牌
		/// </summary>
		/// <param name="Player">处理过后的各个玩家的牌</param>
		public void print ( string[][] Player ) {
			for ( int i = 0; i < Player.Length; i++ ) {
				if ( i == 0 ) {
					Console.ForegroundColor = ConsoleColor.Red;
					Console.Write("地主的牌为：");
				} else {
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("农民的牌为：");
				}
				for ( int j = 0; j < Player[i].Length; j++ ) {
					Console.ForegroundColor = ConsoleColor.Blue;
					Console.Write(Player[i][j] + "  ");
				}
				Console.WriteLine("\n");
			}
		}
	}
	#endregion
}