using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _9_6__9_7作业 {
	internal class BattleBoss {
		public BattleBoss () { 
			Character character = new BOSS("狂战士",80,3000);
			Character character1 = new BOSS("剑魂",50,12);
			Character character2 = new BOSS("阿修罗",120,6);
			Character Boss = new BOSS("普通怪",100,1);
			Character Boss1 = new BOSS("精英怪",1000,3);
			Character Boss2 = new BOSS("BOSS",10000,10);
			Character[] characters = new[] {Boss ,Boss1, Boss2 };
			Console.WriteLine("编号\t玩家名称  \t生命值 \t攻击力");
			Console.WriteLine("1.\t" + character.Name + "  \t" + character.HP + "  \t" + character.KT);
			Console.WriteLine("2.\t" + character1.Name + "      \t" + character1.HP + "  \t" + character1.KT);
			Console.WriteLine("3.\t" + character2.Name + "  \t" + character2.HP + "  \t" + character2.KT+"\n");
			Console.Write("请选择玩家职业：");
			int num = int.Parse(Console.ReadLine());
			switch ( num ) {
				case 1:
					BattleMessage(character , characters);
                    break;
				case 2:
					BattleMessage(character1 , characters);
					break;
				case 3:
					BattleMessage(character2 , characters);
					break;
			}
		}
		/// <summary>
		/// 判断游戏是否结束
		/// </summary>
		public static void BattleMessage (Character character , Character[] characters) {
			while ( true ) {
				if ( character is BOSS ) {
					BOSS bOSS = character as BOSS;
					for ( int i = 0; i < characters.Length; i++ ) {
						BOSS bOSS1 = characters[i] as BOSS;
						if ( bOSS1.HP > 0 ) {
							if ( bOSS.HP <= 0 ) {
								Console.Clear();
								Console.SetCursorPosition(50 , 10);
								Console.ForegroundColor = ConsoleColor.Red;
								Console.WriteLine("YOU ARE LOSE");
								Console.SetCursorPosition(48 , 12);
								Console.ForegroundColor = ConsoleColor.Green;
								Console.WriteLine(bOSS.Name+"被" + bOSS1.Name + "杀死！");
								Console.SetCursorPosition(49 , 14);
								Console.WriteLine(bOSS1.Name + "还剩" + bOSS1.HP + "血");
								break;
							}
							//battle
							bOSS.Battle(bOSS1);
							bOSS1.Battle(bOSS);
							i--;
						} else {
							continue;
						}
					}
					if ( bOSS.HP > 0 ) {
						Console.Clear();
						Console.SetCursorPosition(50 , 10);
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine("YOU ARE WIN");
						Console.SetCursorPosition(49 , 12);
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("所有怪兽已死亡");
						break;
					} else { 
						break;
					}
				}
			}
		}
	}
	/// <summary>
	/// 打怪兽中的人物创造
	/// </summary>
	public class Character {
		public string Name { get; set; }
		public int HP { get; set; }
		public int KT { get; set; }
		/// <summary>
		/// 人物构造函数
		/// </summary>
		public Character (string Name ,int HP , int KT) { 
			this.Name = Name;
			this.HP = HP;
			this.KT = KT;
		}
	}
	/// <summary>
	/// 怪兽创建
	/// </summary>
    public class BOSS : Character{
		/// <summary>
		/// 怪兽构造函数链
		/// </summary>
		public BOSS ( string Name , int HP , int KT ) : base(Name , HP , KT) { }
		/// <summary>
		/// Battle 玩家打怪兽
		/// </summary>
		public void Battle (Character character) {
			this.HP -= character.KT;
		}
		/// <summary>
		/// Battle 怪兽打玩家
		/// </summary>
		public void Battle ( BOSS character ) {
			this.HP -= character.KT;
		}
	}
}
