using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 周六作业3
{
    public class Monster
    {
        //名字
        public string Name { get; set; }
        //生命值
        public int HP { get; set; }
        //攻击力
        public int ATK { get; set; }

        public Monster(string name, int hP, int aTK)
        {
            Name = name;
            HP = hP;
            ATK = aTK;
        }
    }
    public class Player
    {
        //名字
        public string Name { get; set; }
        //生命值
        public int HP { get; set; }
        //攻击力
        public int ATK { get; set; }

        public void setAttribute(string name, int hp, int atk)
        {
            Name = name;
            HP = hp;
            ATK = atk;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请选择职业:1.狂战士 2.剑魂 3.阿修罗");
            int id = Convert.ToInt32(Console.ReadLine());
            //先创建一个没有值的角色
            Player player = new Player();
            switch (id)
            {
                case 1:
                    player.setAttribute("狂战士", 80, 10);
                    break;
                case 2:
                    player.setAttribute("剑魂", 50, 12);
                    break;
                case 3:
                    player.setAttribute("阿修罗", 120, 6);
                    break;
                default:
                    Console.WriteLine("输入不正确");
                    return;
            }
            //创建怪物
            List<Monster> list = new List<Monster>()
            {
                new Monster("普通怪",100,1),
                new Monster("精英怪",1000,3),
                new Monster("BOSS",10000,10)
            };
            //遍历三个怪
            foreach (Monster m in list)
            {
                while (player.HP > 0 && m.HP > 0)
                {
                    player.HP -= m.ATK;
                    m.HP -= player.ATK;
                }

                if(player.HP <= 0)
                {
                    Console.WriteLine($"玩家死了，对战{m.Name}的时候,怪物剩余血量{m.HP}");
                    return;
                }
            }
            Console.WriteLine("玩家赢了");
        }
    }
}
