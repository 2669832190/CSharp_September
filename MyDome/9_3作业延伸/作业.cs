using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01值日
{
    //一个结构体表示一组值日
    public struct Team
    {
        //日期信息
        public string _date;
        //星期几
        public string _week;
        //谁值日
        public string[] _name;

    }

    internal class Program
    {
        static void Maina(string[] args)
        {
            string[] nameList = { "王耀", "李文斌", "杨栋", "张相龙", "李政阳","吴焕鹏", "李泓江", "王宁宁",
                "王恩楚", "许家豪", "王一鸣", "张超峰", "裴开鹏", "楚文淼", "胡智聪", "尤贵才", "司宇帆",
                "马旭光", "郑珏", "徐广辉", "刘世豪", "韩铁城", "张权浩", "王宏冉", "韩文杰",
                "马智浩", "冉中良", "候立芃", "李宗桓", "杨成乾", "马啸天", "周新雨", "刘学良",
                "孙金明", "周彬", " 李耀泽", "邢志迪", "王文博", "王鑫洋", "邹旗顺", "陈朋"};

            /*
            值日表
            一天两个人值日
            最终 输出 xxxx年xx月xx日 星期x 谁和谁 值日
             */

            //第一步:创建一个结构体数组 因为一个结构体表示一组值日
            //需要21个结构体 所以我们可以创建长度为21的结构体数组
            Team[] teams = new Team[nameList.Length / 2 + 1];

            //日期
            DateTime time = DateTime.Now;

            //第二步:通过遍历给每一组赋值
            for (int i = 0; i < teams.Length; i++)
            {
                //获取日期信息
                teams[i]._date = time.Date.ToString("yyyy-MM-dd");
                //获取星期几
                teams[i]._week = time.ToString("dddd");
                //日期+1
                time = time.AddDays(1);
                //如果是星期日 跳过一天
                if (time.DayOfWeek == 0)
                {
                    time = time.AddDays(1);
                }
                //谁值日
                teams[i]._name = new string[2];
                //i = 0  nameList[0] nameList[1]
                //i = 1  nameList[2] nameList[3]
                //i = 2  nameList[4] nameList[5]
                //i = 任意数 nameList[i*2] nameList[i*2+1]
                teams[i]._name[0] = nameList[i * 2];

                //判断最后一组
                //nameList.Length - 1 最后一个人的索引
                //i * 2 + 1     将要使用的索引
                //如果 最后一个人的索引 >= 我们准备使用的索引
                //这个索引才可以使用
                if (nameList.Length - 1 >= i * 2 + 1)
                {
                    teams[i]._name[1] = nameList[i * 2 + 1];
                }

            }
            //第三步: 遍历值日生数组 输出
            foreach (Team team in teams)
            {
                Console.WriteLine(team._date + "  " + team._week + "  " + team._name[0] + "  " + team._name[1]);
            }
        }
    }
}
