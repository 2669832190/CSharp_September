namespace _9_4作业 {
	internal class 扑克牌升级版 {
		public static void Main () {
			Cards cards = new Cards();
			//int[][] ints = cards.Card();
			//cards.print(cards.Player(ints));
			cards.fapai(cards.Change(cards.Card()));
		}
	}
	public class Cards {
		public int[] RHeart;
		public int[] RDiamond;
		public int[] BSpade;
		public int[] BClub;
		public int[] Jokers;
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

		public string[][] Change ( int[][] Card ) {
			string[] RHeart1;
			string[] RDiamond1;
			string[] BSpade1;
			string[] BClub1;
			string[] Jokers1;
			string[][] cards = {
			RHeart1 = new string[13],
			RDiamond1 = new string[13],
			BSpade1 = new string[13],
			BClub1 = new string[13],
			Jokers1 = new string[2]
			};
			for ( int i = 0; i < cards.Length; i++ ) {
				for ( int j = 0; j < cards[i].Length; j++ ) {
					if ( i == 4 ) {
						cards[i][j] = Card[i][j].ToString();
						if ( j == 0 ) {
							cards[i][j] = "Joker";
						} else {
							cards[i][j] = "joker";
						}
					} else {
						if ( j == 0 ) {
							cards[i][j] = "A";
						} else if ( j == 10 ) {
							cards[i][j] = "J";
						} else if ( j == 11 ) {
							cards[i][j] = "Q";
						} else if ( j == 12 ) {
							cards[i][j] = "K";
						} else {
							cards[i][j] = Card[i][j].ToString();
						}
					}
				}
			}
			return cards;
		}

		public void fapai ( string[][] Cards ) {

			Console.Write("地主的牌为：");
			int count =0;
		again:
			Random random = new Random();
			int anum = random.Next(0,5);
			int Num = random.Next(0,13);
			int Jnum = random.Next(0,2);
			if ( anum != 4 ) {
				switch ( anum ) {
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Cards[anum][Num] + " ");
						if ( count <= 20 ) {
							count++;
							goto again;
						} else {
							break;
						}
					case 1:
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.Write(Cards[anum][Num] + " ");
						if ( count <= 20 ) {
							count++;
							goto again;
						} else {
							break;
						}

					case 2:
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write(Cards[anum][Num] + " ");
						if ( count <= 20 ) {
							count++;
							goto again;
						} else {
							break;
						}
					case 3:
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write(Cards[anum][Num] + " ");
						if ( count <= 20 ) {
							count++;
							goto again;
						} else {
							break;
						}
				}
			} else {
				switch ( anum ) {
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Cards[anum][Jnum] + " ");
						if ( count <= 20 ) {
							count++;
							goto again;
						} else {
							break;
						}
					case 1:
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write(Cards[anum][Jnum] + " ");
						if ( count <= 20 ) {
							count++;
							goto again;
						} else {
							break;
						}
				}
			}

			Console.WriteLine();
			Console.Write("农民的牌为：");
			int count1 = 0;
		again1:
			if ( anum != 4 ) {
				switch ( Num ) {
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Cards[anum][Num] + " ");
						if ( count1 <= 17 ) {
							count1++;
							goto again1;
						} else {
							break;
						}
					case 1:
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.Write(Cards[anum][Num] + " ");
						if ( count1 <= 17 ) {
							count1++;
							goto again1;
						} else {
							break;
						}
					case 2:
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write(Cards[anum][Num] + " ");
						if ( count1 <= 17 ) {
							count1++;
							goto again1;
						} else {
							break;
						}
					case 3:
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write(Cards[anum][Num] + " ");
						if ( count1 <= 17 ) {
							count1++;
							goto again1;
						} else {
							break;
						}
				}
			} else {
				switch ( Jnum ) {
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Cards[anum][Jnum] + " ");
						if ( count1 <= 17 ) {
							count1++;
							goto again1;
						} else {
							break;
						}
					case 1:
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write(Cards[anum][Jnum] + " ");
						if ( count1 <= 17 ) {
							count1++;
							goto again1;
						} else {
							break;
						}
				}
			}
			Console.WriteLine();
			Console.Write("农民的牌为：");
			int count2 = 0;
		again2:
			if ( anum != 4 ) {
				switch ( Num ) {
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Cards[anum][Num] + " ");
						if ( count2 <= 17 ) {
							count2++;
							goto again2;
						} else {
							break;
						}
					case 1:
						Console.ForegroundColor = ConsoleColor.Magenta;
						Console.Write(Cards[anum][Num] + " ");
						if ( count2 <= 17 ) {
							count2++;
							goto again2;
						} else {
							break;
						}
					case 2:
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write(Cards[anum][Num] + " ");
						if ( count2 <= 17 ) {
							count2++;
							goto again2;
						} else {
							break;
						}
					case 3:
						Console.ForegroundColor = ConsoleColor.DarkCyan;
						Console.Write(Cards[anum][Num] + " ");
						if ( count2 <= 17 ) {
							count2++;
							goto again2;
						} else {
							break;
						}
				}
			} else {
				switch ( Jnum ) {
					case 0:
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(Cards[anum][Jnum] + " ");
						if ( count2 <= 17 ) {
							count2++;
							goto again2;
						} else {
							break;
						}
					case 1:
						Console.ForegroundColor = ConsoleColor.DarkBlue;
						Console.Write(Cards[anum][Jnum] + " ");
						if ( count2 <= 17 ) {
							count2++;
							goto again2;
						} else {
							break;
						}
				}
			}


		}















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
		public string[] player1;
		public string[] player2;
		public string[] player3;
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
}
