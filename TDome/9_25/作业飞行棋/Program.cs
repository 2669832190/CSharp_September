using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业飞行棋
{
    internal class Program
    {

        //1. 炸弹 后退五步
        //2. 传送门 再投一次
        //3. 火箭 前进三步

        //地图怎么生成？
        //1. 规定有几行，每行多少步
        //2. 横着的怎么处理?单数行 从左往右 递增，双数行 从右往左 递减
        //3. 竖着怎么处理?单数行 先输出空格 再输出内容 记得换行，双数行 输出内容 换行
        //4. 道具怎么办?随机位置 保存进道具数组 生成地图的时候 如果格子上有道具 就生成道具的图标
        //5. 玩家位置怎么处理?玩家类 创建两个玩家对象 在玩家类里保存位置信息
        //生成地图的时候 如果现在要生成的位置==玩家的坐标 生成玩家的图标

        //地图类 负责处理地图 有一个生成地图的方法 有一个生成单个格子的方法
        //生成单个格子的方法 只考虑这个位置是什么 如果是道具 生成道具 如果有玩家 生成玩家
        //生成地图的方法 处理第几行第几列 打印在哪个位置 调用单个格子的方法

        //玩家类 保存玩家的名字 头像 坐标

        //程序的主逻辑类
        //先创建玩家 选择头像 运行程序

        static Random r = new Random();

        static void Main(string[] args)
        {
            //设置控制台的字符编码
            Console.OutputEncoding = Encoding.UTF8;

            //创建玩家
            Player p1 = getPlayer();
            Player p2 = getPlayer();

            //创建地图
            Map map = new Map(p1, p2, 100, 3, 30);

            //当前是谁的回合?
            //如果是玩家1的回合 == true
            //如果是玩家2的回合 == false
            bool isPlayer1 = true;
            //当前轮到谁移动
            Player p = null;
            //循环 如果没有人到终点 才进行移动
            while (p1.pos < 100 && p2.pos < 100)
            {
                //三元表达式
                p = isPlayer1 ? p1 : p2;

                Console.WriteLine($"当前是{p.Name}的回合");
                Console.WriteLine("请按下任意键投骰子");
                Console.ReadKey();
                //要移动的步数
                int pos = r.Next(1, 7);
                Console.WriteLine($"投掷出{pos}点，按任意键开始移动");
                Console.ReadKey();

            move:
                //移动
                //返回 移动到的格子上 有什么道具
                string prop = map.PlayerMove(p, pos);

                switch (prop)
                {
                    case "☀":
                        Console.WriteLine("你踩到了炸弹,后退5步,按下任意键继续");
                        Console.ReadKey();
                        //要移动的步数
                        pos = -5;
                        goto move;
                    case "◎":
                        Console.WriteLine("你踩到了传送门,再投一次,按下任意键继续");
                        Console.ReadKey();
                        //每个回合结束后 都要切换角色
                        //那我们提前切换一次 回合结束后会切换回来
                        isPlayer1 = !isPlayer1;
                        break;
                    case "✈":
                        Console.WriteLine("你踩到了火箭,前进3步,按下任意键继续");
                        pos = 3;
                        goto move;
                }


                //每次移动完 切换移动的角色
                isPlayer1 = !isPlayer1;
            }
            Console.WriteLine($"游戏结束，获胜者是{p.Name}{p.Avatar}");
        }

        //创建玩家的方法
        private static Player getPlayer()
        {
            Console.WriteLine("请输入玩家名字:");
            string playerName = Console.ReadLine();

        selectHeadImg:
            Console.WriteLine("请选择头像:");
            Console.WriteLine("0.△ 1.☆ 2.♡ 3.♤ 4.♧ 5.♩ 6.♫ 7.♬");
            //输入头像序号
            string headImg = Console.ReadLine();
            //玩家头像的符号
            string headSymbol;

            switch (headImg)
            {
                case "0":
                    headSymbol = "△";
                    break;
                case "1":
                    headSymbol = "☆";
                    break;
                case "2":
                    headSymbol = "♡";
                    break;
                case "3":
                    headSymbol = "♤";
                    break;
                case "4":
                    headSymbol = "♧";
                    break;
                case "5":
                    headSymbol = "♩";
                    break;
                case "6":
                    headSymbol = "♫";
                    break;
                case "7":
                    headSymbol = "♬";
                    break;
                default:
                    Console.WriteLine("输入的内容没有此选项!");
                    goto selectHeadImg;
            }

            return new Player() { Name = playerName, Avatar = headSymbol };
        }
    }
}
