using _9_9作业;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9作业 {
	public class Players {
		public string Name { get; set; }
		public int HP { get; set; }
		public int ATK { get; set; }
		public string Skill { get; set; }
		public Players ( string Name , int HP , int ATK , string Skill) {
			this.Name = Name;
			this.HP = HP;
			this.ATK = ATK;
			this.Skill = Skill;
		}
	}

	public class Monster { 
		public string Name { get; set; }
		public int HP { get; set; }
		public int ATK { get; set; }
		public Monster(string Name , int HP , int ATK ) { 
			this.Name = Name;
			this.HP = HP;
			this.ATK = ATK;
		}

	}
	public class Boss : Monster {
		public string Skill { get; set; } = "狂暴";
		public Boss ( string Name , int HP , int ATK ) : base(Name , HP , ATK) { }
	}




	internal class BattleBoss {
		public static void maina () {
			Players players = new Players("狂战士",80,10,"回血");
			Players players1 = new Players("剑魂",50,12, "闪现");
			Players players2 = new Players("阿修罗",120,6, "冰冻");
			Monster monster = new Monster("普通怪",100,1);
			Monster monster1 = new Monster("精英怪",1000,3);
			Monster monster2 = new Boss("BOSS",10000,10);
			Monster[] monsters = { monster, monster1 , monster2 };
			Console.WriteLine("编号\t玩家名称  \t生命值 \t攻击力");
			Console.WriteLine("1.\t" + players.Name + "  \t" + players.HP + "  \t" + players.ATK);
			Console.WriteLine("2.\t" + players1.Name + "      \t" + players1.HP + "  \t" + players1.ATK);
			Console.WriteLine("3.\t" + players2.Name + "  \t" + players2.HP + "  \t" + players2.ATK + "\n");
			Console.Write("请选择玩家职业：");
			bool playeriswin = false;
			int num = int.Parse(Console.ReadLine());
			switch ( num ) {
				case 1:
					for ( int i = 0; i < monsters.Length; i++ ) {
						monsters[i].HP -= players.ATK;
						players.HP -= monsters[i].ATK;
						//Console.WriteLine(players1.Name + "还剩：" + players1.HP + "血，" + monsters[i].Name + "还剩" + monsters[i].HP + "血。");
						Random random = new Random();
						int count = random.Next(100);
						if ( count < 25 ) {
							players.HP += 2;
							Console.WriteLine("触发" + players.Name + "技能：" + players.Skill);
							Console.WriteLine(players.Name + "还剩：" + players.HP + "血，" + monsters[i].Name + "还剩" + monsters[i].HP + "血。");
						}
						if ( i == 2 && monsters[i].HP < 1000 * 0.3 ) {
							players.HP = players.HP / 2;
							Console.WriteLine("BOSS触发被动防御技能！！！");
						}
						if ( i == 2 && monsters[i].HP<=0 ) {
							playeriswin = true;
							//break;
                            Console.WriteLine("!!!");
                        }
						if ( players.HP <= 0 ) {
							Console.Clear();
							Console.SetCursorPosition(50 , 10);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("YOU ARE LOSE");
							Console.SetCursorPosition(48 , 12);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine(players.Name + "被" + monsters[i].Name + "杀死！");
							Console.SetCursorPosition(49 , 14);
							Console.WriteLine(monsters[i].Name + "还剩" + monsters[i].HP + "血");
							break;
						}
						if ( monsters[i].HP <= 0 ) {
							continue;
						} else {
							i--;
						}			
					}
					break;
				case 2:
					for ( int i = 0; i < monsters.Length; i++ ) {
						monsters[i].HP -= players1.ATK;
						players1.HP -= monsters[i].ATK;
						//Console.WriteLine(players1.Name + "还剩：" + players1.HP + "血，" + monsters[i].Name + "还剩" + monsters[i].HP + "血。");
						Random random = new Random();
						int count = random.Next(100);
						if ( count < 50 ) {
							players1.HP += monsters[i].ATK;
							//Console.WriteLine("触发" + players1.Name + "技能：" + players1.Skill);
							//Console.WriteLine(players1.Name + "还剩：" + players1.HP + "血，" + monsters[i].Name + "还剩" + monsters[i].HP + "血。");
						}
						if ( i == 2 && monsters[i].HP < 1000 * 0.3 ) {
							players1.HP = players1.HP / 2;
							//Console.WriteLine("BOSS触发被动防御技能！！！");
						}
						if ( i == 2 && monsters[i].HP <= 0 ) {
							playeriswin = true;
							Console.WriteLine("!!!");
						}
						if ( players1.HP <= 0 ) {
							Console.Clear();
							Console.SetCursorPosition(50 , 10);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("YOU ARE LOSE");
							Console.SetCursorPosition(48 , 12);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine(players.Name + "被" + monsters[i].Name + "杀死！");
							Console.SetCursorPosition(49 , 14);
							Console.WriteLine(monsters[i].Name + "还剩" + monsters[i].HP + "血");
							break;
						}
						if ( monsters[i].HP <= 0 ) {
							continue;
						} else {
							i--;
						}
					}
					break;
				case 3:
					for ( int i = 0; i < monsters.Length; i++ ) {
						monsters[i].HP -= players2.ATK;
						players2.HP -= monsters[i].ATK;
						//Console.WriteLine(players1.Name + "还剩：" + players1.HP + "血，" + monsters[i].Name + "还剩" + monsters[i].HP + "血。");
						Random random = new Random();
						int count = random.Next(100);
						if ( count < 50 ) {
							players2.HP += monsters[i].ATK;
							//Console.WriteLine("触发" + players1.Name + "技能：" + players1.Skill);
							//Console.WriteLine(players1.Name + "还剩：" + players1.HP + "血，" + monsters[i].Name + "还剩" + monsters[i].HP + "血。");
						}
						if ( i == 2 && monsters[i].HP < 1000 * 0.3 ) {
							players2.HP = players2.HP / 2;
							//Console.WriteLine("BOSS触发被动防御技能！！！");
						}
						if ( i == 2 && monsters[i].HP <= 0 ) {
							playeriswin = true;
							Console.WriteLine("!!!");
						}
						if ( players2.HP <= 0 ) {
							Console.Clear();
							Console.SetCursorPosition(50 , 10);
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine("YOU ARE LOSE");
							Console.SetCursorPosition(48 , 12);
							Console.ForegroundColor = ConsoleColor.Green;
							Console.WriteLine(players2.Name + "被" + monsters[i].Name + "杀死！");
							Console.SetCursorPosition(49 , 14);
							Console.WriteLine(monsters[i].Name + "还剩" + monsters[i].HP + "血");
							break;
						}
						if ( monsters[i].HP <= 0 ) {
							continue;
						} else {
							i--;
						}
					}
					break;
			}
		}
	}
}