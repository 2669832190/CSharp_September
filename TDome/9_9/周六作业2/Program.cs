using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 周六作业2
{
    //一个结构体表示一张牌
    public struct Item
    {
        public string _num;
        public Color _color;
    }
    //枚举 花色
    public enum Color
    {
        黑桃 = 1, 红心, 梅花, 方块
    }

    internal class Program
    {
        //牌的点数 和排序的时候 对应的顺序
        //键 牌的点数
        //值 排序的时候的序号
        static Dictionary<string, int> NumLevel = new Dictionary<string, int>()
        {
            {"大王",-100 },
            {"小王",-50 },
            {"2",1 },
            {"A",2 },
            {"K",3 },
            {"Q",4 },
            {"J",5 },
            {"10",6 },
            {"9",7 },
            {"8",8 },
            {"7",9 },
            {"6",10 },
            {"5",11 },
            {"4",12 },
            {"3",13 }
        };

        //按照花色的字典
        static Dictionary<string, int> ColorLevel = new Dictionary<string, int>()
        {
            {"黑桃",1 },
            {"梅花",2 },
            {"红心",3 },
            {"方块",4 }
        };

        //牌堆
        static List<Item> Cards = new List<Item>();

        //初始化牌堆
        static void InitCards()
        {
            //点数
            foreach (var card in NumLevel)
            {
                //花色
                foreach (var color in ColorLevel)
                {
                    //处理大小王
                    if (card.Value < 0)
                    {
                        Item item1 = new Item();
                        item1._num = card.Key;
                        Cards.Add(item1);
                        //跳过花色的4次循环
                        break;
                    }


                    //一张牌
                    Item item;
                    item._num = card.Key;
                    //牌的花色
                    item._color = (Color)Enum.Parse(typeof(Color), color.Key);
                    //放到牌堆里
                    Cards.Add(item);
                }
            }
        }

        //发牌 传入牌发给谁 发几张牌
        static void DealCards(List<Item> plays, int count)
        {
            Random ran = new Random();
            //{玩家的手牌数量}不等于{要发的牌的数量}
            while (plays.Count != count)
            {
                // [0,54)
                //准备发的牌的ID
                int IssuedCardsID = ran.Next(0, Cards.Count);
                //玩家的手牌里 加上 牌堆里对应ID的牌
                plays.Add(Cards[IssuedCardsID]);
                //牌堆里删除对应的牌
                Cards.RemoveAt(IssuedCardsID);
            }
        }
        //花色排序 传入手牌
        static List<Item> ColorSort(List<Item> plays)
        {
            //新手牌数组 把原来的手牌排序后依次放入新数组
            List<Item> newCards = new List<Item>();

            while (plays.Count != 0)
            {
                //先拿到第一张牌
                Item item1 = plays[0];
                //判断大小王
                if(item1._num == "大王" || item1._num == "小王")
                {
                    newCards.Add(item1);
                    plays.RemoveAt(0);
                }
                else
                {
                    //先拿到所有点数为2的牌 按照花色排完之后
                    //再拿点数为1的牌 再按照花色排序
                    //拿到所有手牌中第一张牌点数的牌
                    //res里保存的是所有点数为2的牌
                    List<Item> res = plays.FindAll(x => x._num == plays[0]._num);
                    //删除掉原牌组中点数为2的牌
                    plays.RemoveRange(0, res.Count);
                    //把res按照花色排序
                    //一张牌的花色 x._color
                    //在字典中查找对应的值 ColorLevel[键]
                    res.Sort((x,y) => ColorLevel[x._color.ToString()] - ColorLevel[y._color.ToString()]);
                    //把按照花色排完序的牌放到新手牌数组
                    newCards.AddRange(res);
                }
            }
            return newCards;
        }

        static void Main(string[] args)
        {
            //初始化牌堆
            InitCards();
            //创建三个人的手牌
            List<Item> wangEnChu = new List<Item>();
            List<Item> yaoMing = new List<Item>();
            List<Item> kunKun = new List<Item>();
            //发牌
            DealCards(wangEnChu, 17);
            DealCards(yaoMing, 17);
            DealCards(kunKun, 17);
            //随机个地主
            Random ran = new Random();
            int diZhu = ran.Next(3);
            //发地主牌
            switch (diZhu)
            {
                case 0:
                    wangEnChu.AddRange(Cards);
                    Cards.Clear();
                    break;
                case 1:
                    yaoMing.AddRange(Cards);
                    Cards.Clear();
                    break;
                case 2:
                    kunKun.AddRange(Cards);
                    Cards.Clear();
                    break;
            }
            //wangEnChu[0]._num 拿到的是王恩楚的第一张牌的点数 对应字典中的键
            //NumLevel[键] 拿到对应的值
            wangEnChu.Sort((x, y) => NumLevel[x._num] - NumLevel[y._num]);
            yaoMing.Sort((x, y) => NumLevel[x._num] - NumLevel[y._num]);
            kunKun.Sort((x, y) => NumLevel[x._num] - NumLevel[y._num]);
            //输出
            Console.Write("王恩楚的牌:");
            wangEnChu.ForEach(x => Console.Write($"{x._color}{x._num} "));
            Console.WriteLine();
            Console.Write("姚明的牌:");
            yaoMing.ForEach(x => Console.Write($"{x._color}{x._num} "));
            Console.WriteLine();
            Console.Write("坤坤的牌:");
            kunKun.ForEach(x => Console.Write($"{x._color}{x._num} "));
            Console.WriteLine();
            Console.WriteLine("============================");

            //按照花色排序
            List<Item> newWangEnChu = ColorSort(wangEnChu);
            List<Item> newyaoMing = ColorSort(yaoMing);
            List<Item> newkunKun = ColorSort(kunKun);

            //输出
            Console.Write("王恩楚的牌:");
            newWangEnChu.ForEach(x => Console.Write($"{x._color}{x._num} "));
            Console.WriteLine();
            Console.Write("姚明的牌:");
            newyaoMing.ForEach(x => Console.Write($"{x._color}{x._num} "));
            Console.WriteLine();
            Console.Write("坤坤的牌:");
            newkunKun.ForEach(x => Console.Write($"{x._color}{x._num} "));
            Console.WriteLine();
        }
    }
}
