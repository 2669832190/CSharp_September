using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03值日表
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

        /* 或者使用两个变量 表示两个值日的人
        public string _name1;
        public string _name2;
        */
    }

    internal class Program
    {
        static void Main(string[] args)
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
            Team[] teams = new Team[21];
            //可以通过索引访问对应的结构体 索引表示第几组
            teams[0]._date = "xxxx年";

            //第二步:通过遍历给每一组赋值
            //日期从当前这一天开始 循环每运行一次+1天
            //星期几 直接从日期类里拿到对应的星期几
            //值日 第一次循环的时候 赋值为前两个人 每循环一次 +2(向后两个人)

            //第三步: 遍历值日生数组 输出
        }
    }
}
