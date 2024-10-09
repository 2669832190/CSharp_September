using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6__9_7作业 {
	/// <summary>
	/// 枚举牌的花色
	/// </summary>
	public enum E_Flower {
		/// <summary>
		/// 红桃
		/// </summary>
		_Heart,
		/// <summary>
		/// 黑桃
		/// </summary>
		_Spade,
		/// <summary>
		/// 梅花
		/// </summary>
		_Club,
		/// <summary>
		/// 方块
		/// </summary>
		_Diamond,
		/// <summary>
		/// 王
		/// </summary>
		_King
	}
	/// <summary>
	/// 定义每一张牌的结构体
	/// </summary>
	public struct Cards {
		public int num;
		public string flower;
	}
	/// <summary>
	/// 牌类
	/// </summary>
    internal class Card {
		/// <summary>
		/// 初始化牌堆
		/// </summary>
		/// <returns>返回一副牌</returns>
		public static Cards[] Assign () { 
			Cards[] cards = new Cards[54];
			int cardnum = 1;
			int Flowernum = 0;
			for ( int i = 0; i < cards.Length; i++ ) { 
				cards[i].num = cardnum;
				cardnum++;
				if ( cardnum == 14 ) { 
					cardnum = 0;
					cardnum++;
				}
				cards[i].flower = ((E_Flower)Flowernum).ToString();
				if ( (i+1) % 13 ==0 ) { 
					Flowernum++;
				}
			}
			return cards;
		}
		/// <summary>
		/// 给每个玩家发牌，并进行点数的排序以及花色的排序
		/// </summary>
		/// <param name="cards">传入一整副牌</param>
		/// <returns>返回一个多维数组，里面包含三个玩家的手牌</returns>
		public static Cards[][] DealCardsAndSort ( Cards[] cards) {
			//玩家手牌
			Cards[][] players = new Cards[][] {
				new Cards[20],
				new Cards[17],
				new Cards[17]
			};
			//随机发牌
			for ( int i = 0; i < players.Length; i++ ) {
				for ( int j = 0; j < players[i].Length; j++ ) { 
					again:
					Random random = new Random();
					int points = random.Next(0,54);
					if ( cards[points].num != -1 ) {
						if ( points == 52 ) {
							players[i][j] = cards[points];
							players[i][j].num = 14;
							cards[points].num = -1;
						} else if ( points == 53 ) {
							players[i][j] = cards[points];
							players[i][j].num = 15;
							cards[points].num = -1;
						} else {
							players[i][j] = cards[points];
							cards[points].num = -1;
						}
					} else {
						goto again;
					}
				}
			}
			//点数排序
			for ( int i = 0; i < players.Length; i++ ) {
				for ( int k = 0; k < players[i].Length; k++ ) {
					for ( int j = 0; j < players[i].Length - 1; j++ ) {
						if ( players[i][j].num > players[i][j + 1].num ) {
							Cards temp = players[i][j];
							players[i][j] = players[i][j + 1];
							players[i][j + 1] = temp;
						}
					}
				}
			}
			//花色排序
			for ( int i = 0; i < players.Length; i++ ) {
				for ( int j = 0; j < players[i].Length; j++ ) {
					for ( int k = 0; k < players[i].Length-1; k++ ) {
						E_Flower tmpe1 = (E_Flower)System.Enum.Parse(typeof(E_Flower),players[i][k].flower);
						E_Flower tmpe2 = (E_Flower)System.Enum.Parse(typeof(E_Flower),players[i][k+1].flower);
						if ( (int)tmpe1 > (int)tmpe2) {
							Cards temp = players[i][k];
							players[i][k] = players[i][k + 1];
							players[i][k + 1] = temp;
						}
					}
				}
			}
			return players;
		}
		/// <summary>
		/// 通过打印 改变特殊扑克牌的牌面值
		/// </summary>
		/// <param name="num">传入每一个扑克牌的牌面数字</param>
		public static void Change (int num) {
			if ( num > 13 ) {
				if ( num == 14 ) {
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Joker ");
				} else if ( num == 15 ) {
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write("joker ");
				}
			} else {
				switch ( num ) {
					case 1:
						Console.Write("A ");
						break;
					case 11:
						Console.Write("J ");
						break;
					case 12:
						Console.Write("Q ");
						break;
					case 13:
						Console.Write("K ");
						break;
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
						Console.Write(num + " ");
						break;

				}
			}
		}
		/// <summary>
		/// 判断扑克牌是否为同一花色
		/// </summary>
		/// <param name="tempf">传入每个扑克牌的花色</param>
		/// <param name="tempn">传入每一个扑克牌的牌面点数</param>
		public static void printf ( string tempf , int tempn ) {
			if ( tempf == E_Flower._Heart.ToString() ) {
				Console.ForegroundColor = ConsoleColor.Red;
				Change(tempn);
			} else if ( tempf == E_Flower._Diamond.ToString() ) {
				Console.ForegroundColor = ConsoleColor.Magenta;
				Change(tempn);
			} else if ( tempf == E_Flower._Club.ToString() ) {
				Console.ForegroundColor = ConsoleColor.Cyan;
				Change(tempn);
			} else if ( tempf == E_Flower._Spade.ToString() ) {
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Change(tempn);
			} else if ( tempf == E_Flower._King.ToString() ) {
				Change(tempn);
			}
		}
		/// <summary>
		/// 按点数以及相同花色进行排序打印
		/// </summary>
		/// <param name="cards">每个玩家的手牌</param>
		public static void PrintfOverPoints ( Cards[][] cards){
			for ( int i = 0; i < cards.Length; i++ ) {
				if ( i == 0 ) {
					Console.Write("地主的牌为：");
					for ( int j = 0; j < cards[i].Length; j++ ) {
						string tempf = cards[i][j].flower;
						int tempn = cards[i][j].num;
						printf(tempf,tempn);
					}
					Console.WriteLine("\n");
				} else {
					Console.ForegroundColor = ConsoleColor.Green;
					Console.Write("农民的牌为：");
					for ( int j = 0; j < cards[i].Length; j++ ) {
						string tempf = cards[i][j].flower;
						int tempn = cards[i][j].num;
						printf(tempf , tempn);
					}
					Console.WriteLine("\n");
				}
            }
		}
	}
}