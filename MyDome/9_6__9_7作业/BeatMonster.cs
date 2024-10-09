using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_6__9_7作业 {
	/// <summary>
	/// 怪兽结构体
	/// </summary>
    public struct Monster {
        public string Name;
        public int HP;
        public int KT;
		/// <summary>
		/// 构造函数
		/// </summary>
		/// <param name="Name"></param>
		/// <param name="HP"></param>
		/// <param name="KT"></param>
        public Monster (string Name,int HP,int KT) { 
            this.Name = Name;
            this.HP = HP;
            this.KT = KT;
        }
		/// <summary>
		/// 怪兽所伤
		/// </summary>
		public void Battle ( Player player , Monster monster ) {
			
			this.HP -= player.KT;
		}
	}
	/// <summary>
	/// 玩家结构体
	/// </summary>
    public struct Player {
        public string Name;
        public int HP;
        public int KT;
		/// <summary>
		/// 构造函数
		/// </summary>
		public Player ( string Name , int HP , int KT ) {
			this.Name = Name;
			this.HP = HP;
			this.KT = KT;
		}
		/// <summary>
		/// 玩家所伤
		/// </summary>
        public void Battle (Player player,Monster monster) {
            this.HP = player.HP - monster.KT;
        }
	}
	internal class BeatMonster {
        /// <summary>
        /// 生成怪兽和玩家放入对应类别的数组中，通过玩家输入的玩家职业进行switch
        /// </summary>
        public static void Generate () {
			Monster monster = new Monster ("普通怪",100,1);
			Monster monster1 = new Monster ("精英怪",1000,3);
			Monster monster2 = new Monster ("BOSS",10000,10);
            Monster[] monsters = new Monster[] { monster, monster1, monster2 };
            Player player = new Player ("狂战士",80,10);
            Player player1 = new Player ("剑魂",50,12);
            Player player2 = new Player ("阿修罗",120,5000);
            Player[] players = new Player[] { player, player1, player2 };
            Console.WriteLine("0."+player.Name+" "+player.HP+" "+player.KT);
            Console.WriteLine("1."+player1.Name+" "+player1.HP+" "+player1.KT);
            Console.WriteLine("2."+player2.Name+" "+player2.HP+" "+player2.KT);
            Console.WriteLine("请选择职业：");
            int num = int.Parse(Console.ReadLine());
            switch ( num ) {
                case 0:
					Console.Clear();
					Battle(players , monsters , num);
                    break;
				case 1:
					Console.Clear();
					Battle(players , monsters , num);
					break;
				case 2:
					Console.Clear();
					Battle(players , monsters , num);
					break;
			}
        }
		/// <summary>
		/// 玩家和每一个怪兽进行战斗
		/// </summary>
		/// <param name="players">玩家选择的类型数组</param>
		/// <param name="monsters">怪兽循环数组</param>
		/// <param name="num">玩家的选择数</param>
        public static void Battle ( Player[] players , Monster[] monsters ,int num) {
			int count=0;
            while ( true ) {
				if ( players[num].HP > 0 && monsters[count].HP > 0 ) {
					players[num].Battle(players[num] , monsters[count]);
					monsters[count].Battle(players[num] , monsters[count]);
					if ( players[num].HP <= 0 ) {
						Console.Clear();
						Console.SetCursorPosition(50 , 10);
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("YOU ARE LOSE");
						Console.SetCursorPosition(46 , 12);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine(players[num].Name + "被" + monsters[count].Name + "杀死！");
						Console.SetCursorPosition(48 , 14);
						Console.WriteLine(monsters[count].Name + "还剩" + monsters[count].HP + "血");
						break;
					}
					if ( monsters[count].HP <= 0 && count <= 2 ) {
						Console.WriteLine(monsters[count].Name+"死亡");
						count++;
						if ( count == 3 ) {
							Console.Clear();
							Console.SetCursorPosition(50 , 10);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("YOU ARE WIN");
							Console.SetCursorPosition(48 , 12);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine("所有怪兽已死亡");
                            break;
						}
					}
					//Console.WriteLine("你正在和" + monsters[count].Name + "战斗！");
					//Console.WriteLine("玩家HP:"+players[num].HP + "\n" + "怪兽HP:"+monsters[count].HP);
					//Console.ReadKey(true);
					//Console.Clear();
				}
			}
		}
	}
}