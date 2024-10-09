using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02正则表达式2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //(匹配其中的内容，将其视为一组进行匹配)
            //[匹配其中的任意一项]
            //{匹配连续的几个字符}
            //^ 匹配字符串的起始位置 在它的后面写匹配内容
            //$ 匹配字符串的结束位置
            //* 匹配出现零次或多次
            //+ 匹配出现一次或多次
            //? 匹配出现零次或一次

            //a-z 所有小写
            //A-Z 所有大写
            //0-9 所有数字 

            //预定义的匹配规则:
            //\d  数字字符
            //\D  非数字字符
            //\w  任何字母数字字符
            //\W  非字母数字字符
            //\s  空白字符
            //\S  非空白字符

            // |  左边的或右边的 满足其中一个

            //邮箱: 数字字母@数字字母.com
            Regex reg = new Regex(@"^\w+@(163|qq).com$");
            string s1 = "123456789@qq.com";
            string s2 = "qwertyui@163.com";

            Match m = reg.Match(s1);
            Console.WriteLine(m.Value);

            Match m2 = reg.Match(s2);
            Console.WriteLine(m2.Value);
        }

        private static void t1()
        {
            string s = "abcdefghi,12345AEIO,U6789,edcbda";

            Regex reg = new Regex(@"");

            //匹配所有符合正则条件的元素
            MatchCollection m = reg.Matches(s);

            foreach (Match m2 in m)
            {
                Console.WriteLine(m2.Index);
                Console.WriteLine(m2.Value);
                Console.WriteLine();
            }
        }

        private static void t2()
        {

            string s = "16234567890";
            //^1 匹配字符串以1开头
            //^1\d 以1开头 之后匹配1个数字
            //^1\d{10} 以1开头 匹配之后的数字 匹配10个
            //^1\d{10}$ 以1开头 匹配数字 匹配10个 匹配字符串是不是已经结束了
            Regex regex = new Regex(@"^1\d{10}$");
            Match m = regex.Match(s);

            Console.WriteLine(m.Index);
            Console.WriteLine(m.Value);
        }
    }
}
