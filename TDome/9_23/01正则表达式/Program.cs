using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01正则表达式
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //正则表达式 匹配字符串(定义一个匹配规则)
            string s = "bc123IJFE0987qwer";
            //[] 匹配其中的字符任意一项
            string rule = "[aeiou]";
            //创建正则表达式
            Regex reg = new Regex(rule);

            /* 匹配符合规则的第一项 Match
            //匹配满足条件的第一项
            Match m = reg.Match(s);
            //匹配到的第一个元素 下标是0 值是a
            Console.WriteLine("index是:" + m.Index);
            Console.WriteLine("value是:" + m.Value);
            */
        }
    }
}
