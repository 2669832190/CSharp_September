using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //题1
            /*
            Console.WriteLine("请输入里程数:");
            //实例化Ticket对象
            Ticket ticket = new Ticket();
            //设置里程数
            ticket.Distance = Convert.ToInt32(Console.ReadLine());
            double dis = ticket.CalculatePrice();
            Console.WriteLine("价格是" + dis);
            */
            //题2
            /*
            Dog dog = new Dog();
            dog.Name = "二哈";
            dog.Gender = "公";
            dog.Age = 12;
            Console.WriteLine("狗的名字是:" + dog.Name + ",性别是:" + dog.Gender + ",年龄是:" + dog.Age);
            Dog dog2 = new Dog();
            dog2.Name = "小白";
            dog2.Gender = "雌";
            dog2.Age = 30;
            Console.WriteLine("狗的名字是:" + dog2.Name + ",性别是:" + dog2.Gender + ",年龄是:" + dog2.Age);
            */

            //T3();
            //T4();
            //T5();
        }
        #region 题3
        public static void T3()
        {
            Console.WriteLine("请输入一行字符:");
            string str = Console.ReadLine();
            //用来记录有几个英文字符
            int english = 0;
            //用来记录有几个数字
            int mathematics = 0;
            //用来记录有几个其他字符
            int otherChar = 0;

            foreach (char c in str)
            {
                if (c >= '0' && c <= '9')
                {
                    mathematics++;
                }
                else if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
                {
                    english++;
                }
                else
                {
                    otherChar++;
                }
            }
            Console.WriteLine($"英文字符有{english}个,数字有{mathematics}个,其他字符有{otherChar}个");
        }
        #endregion

        #region 题4
        //4. "abacbdncabcadbc"  看那个字符出现的次数最多 ?  每个字符各出现了几次？通过字典实现
        public static void T4()
        {
            string str = "abacbdncabcadbc";
            //键 字符
            //值 出现的次数
            Dictionary<char, int> dic = new Dictionary<char, int>();

            foreach (char c in str)
            {
                //如果字典里没有保存过这个字符
                if (!dic.ContainsKey(c))
                {
                    dic.Add(c, 1);
                }
                else
                {
                    dic[c]++;
                }
            }

            foreach (var v in dic)
            {
                Console.WriteLine($"键:{v.Key},值:{v.Value}");
            }

            //那个字符出现的次数最多
            int max = 0;
            //先找出最大值
            foreach (var v in dic)
            {
                if (max < v.Value)
                {
                    max = v.Value;
                }
            }
            //输出最大值的字符
            foreach (var v in dic)
            {
                if (max == v.Value)
                {
                    Console.WriteLine($"出现最多的字符,键:{v.Key},值:{v.Value}");
                }

            }

        }
        #endregion

        /*5. 打扑克
            大王 小王 k q j 10 9 8 7 6 5 4 3 2 A
            在控制台 随机发牌 三个人每人一个数组
            最终输出每个人的牌*/
        public static void T5()
        {
            string[] arr = {
                "大王", "小王",
                "红桃A","红桃2", "红桃3", "红桃4", "红桃5", "红桃6", "红桃7",
                "红桃8","红桃9", "红桃10", "红桃J", "红桃Q", "红桃K",
                "黑桃A","黑桃2","黑桃3","黑桃4","黑桃5","黑桃6","黑桃7",
                "黑桃8","黑桃9","黑桃10","黑桃J","黑桃Q","黑桃K",
                "方片A","方片2","方片3","方片4","方片5","方片6","方片7",
                "方片8","方片9","方片10","方片J","方片Q","方片K",
                "梅花A","梅花2","梅花3","梅花4","梅花5","梅花6","梅花7",
                "梅花8","梅花9","梅花10","梅花J","梅花Q","梅花K"
            };
            //每个人的手牌
            List<string> brand1 = new List<string>();
            List<string> brand2 = new List<string>();
            List<string> brand3 = new List<string>();
            //随机数
            Random ran = new Random();
            //循环发牌
            while (brand1.Count != 18)
            {
                //[0,53]
                int dealCards1 = ran.Next(0, arr.Length);
                int dealCards2 = ran.Next(0, arr.Length);
                int dealCards3 = ran.Next(0, arr.Length);
                //发的这张牌会不会重复?
                if (dealCards1 == dealCards2 || dealCards1 == dealCards3 || dealCards2 == dealCards3)
                {
                    continue;
                }
                //这张牌是不是已经发过了?
                if (arr[dealCards1] == null || arr[dealCards2] == null || arr[dealCards3] == null)
                {
                    continue;
                }
                //给每个人发牌
                brand1.Add(arr[dealCards1]);
                brand2.Add(arr[dealCards2]);
                brand3.Add(arr[dealCards3]);
                //牌堆中对应的牌变为null 防止重复发牌
                arr[dealCards1] = null;
                arr[dealCards2] = null;
                arr[dealCards3] = null;
            }

            foreach (string s in brand1)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (string s in brand2)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
            foreach (string s in brand3)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine();
        }
    }
    #region 题1
    /*1. 写一个Ticket类，表示车票
            有一个路程字段（不能为负数）
            有一个计算价格方法，计算方式如下：
            每公里1元
            0-100公里，票价为原价
            101-200公里，票价打9.5折
            201-300公里，票价打9折
            300公里以上，票价打8折
    */
    public class Ticket
    {
        //表示路程
        private int _distance;

        public int Distance
        {
            get
            {
                return _distance;
            }
            set
            {
                //公里数不能为负数
                if (value < 0)
                {
                    Console.WriteLine("输入的公里数不符合要求");
                    _distance = 0;
                }
                else
                {
                    _distance = value;
                }
            }
        }

        public double CalculatePrice()
        {
            if (_distance <= 100)
            {
                //里程数 = 价格
                return _distance;
            }
            else if (_distance <= 200)
            {
                return _distance * 0.95;
            }
            else if (_distance <= 300)
            {
                return _distance * 0.9;
            }
            else
            {
                return _distance * 0.8;
            }
        }
    }
    #endregion

    #region 题2
    /*2. 写一个Dog类，表示狗
        拥有这些字段：名字，性别，年龄
        性别只能有公和母
        年龄在0-20之间
    */
    public class Dog
    {
        private string _name;
        private string _gender;
        private int _age;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value == "公" || value == "母")
                {
                    _gender = value;
                }
                else
                {
                    Console.WriteLine("输入的性别非法，设置失败!");
                }
            }
        }
        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("输入的年龄不合法，设置失败!");
                }
            }
        }
    }
    #endregion

}
