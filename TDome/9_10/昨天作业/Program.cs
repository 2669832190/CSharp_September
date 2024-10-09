using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    //玩家角色
    public abstract class Player
    {
        //姓名
        public string Name { get; set; }
        //生命值
        public int HP { get; set; }
        //攻击力
        public int ATK { get; set; }
        //闪避
        public bool Evade { get; set; }
        //冰冻
        public bool Frozen { get; set; }

        //技能
        public abstract void Skill(Random random);
    }

    //狂战士
    public class Warrior : Player
    {
        public override void Skill(Random random)
        {
            // [0,4)
            int r = random.Next(4);
            if (r == 0)
            {
                this.HP += 2;
            }
        }
    }
    //剑魂
    public class SwordSoul : Player
    {
        public override void Skill(Random random)
        {
            int r = random.Next(2);
            if (r == 0)
            {
                this.Evade = true;
            }
        }
    }
    //阿修罗
    public class Asura : Player
    {
        public override void Skill(Random random)
        {
            int r = random.Next(4);
            if (r == 0)
            {
                this.Frozen = true;
            }
        }
    }
    //怪物
    public abstract class Monster
    {
        //姓名
        public string Name { get; set; }
        //生命值
        public int HP { get; set; }
        //攻击力
        public int ATK { get; set; }
        //一次性技能 true表示技能用过了
        public bool disposable { get; set; }
        //技能
        public abstract void Skill(Player player);
    }

    //普通怪
    public class OrdinaryMonster : Monster
    {
        public override void Skill(Player player)
        {

        }
    }

    //精英怪
    public class EliteMonster : Monster
    {
        public override void Skill(Player player)
        {

        }
    }

    //BOSS
    public class BOSSMonster : Monster
    {
        public override void Skill(Player player)
        {
            if (this.HP <= 3000 && !this.disposable)
            {
                player.HP /= 2;
                this.disposable = true;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择一个职业:1.狂战士 2.剑魂 3.阿修罗");
            int userPlayer = Convert.ToInt32(Console.ReadLine());
            //声明一个玩家角色
            Player player;
            switch (userPlayer)
            {
                case 1:
                    //在实例化的时候赋值
                    player = new Warrior() { Name = "狂战士", HP = 80, ATK = 10 };
                    break;
                case 2:
                    player = new SwordSoul() { Name = "剑魂", HP = 50, ATK = 12 };
                    break;
                case 3:
                    player = new Asura() { Name = "阿修罗", HP = 120, ATK = 6 };
                    break;
                default:
                    return;
            }
            //怪物
            List<Monster> monsters = new List<Monster>()
            {
                new OrdinaryMonster(){Name = "普通怪",HP = 100,ATK = 1},
                new EliteMonster(){Name = "精英怪",HP=1000,ATK = 3},
                new BOSSMonster(){Name = "BOSS",HP=10000,ATK = 10}
            };

            //开始战斗
            foreach (Monster m in monsters)
            {
                Random random = new Random();
                while (player.HP > 0 && m.HP > 0)
                {
                    //释放技能
                    player.Skill(random);
                    m.Skill(player);

                    //玩家攻击
                    m.HP -= player.ATK;
                    //闪避和冰冻
                    if (player.Evade || player.Frozen)
                    {
                        player.Evade = false;
                        player.Frozen = false;
                    }
                    else
                    {
                        //如果没有冰冻或闪避 怪物攻击
                        player.HP -= m.ATK;
                    }
                }
                if(player.HP <= 0)
                {
                    Console.WriteLine($"游戏结束,在对战{m.Name}的时候死了,对方剩余{m.HP}血");
                    return;
                }
            }

            Console.WriteLine($"赢了,玩家剩余{player.HP}血");
        }
    }
}
