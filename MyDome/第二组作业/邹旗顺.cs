using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 作业1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 使用正则表达式验证IP地址 (如192.168.1.1)
            Console.WriteLine("IP地址:");
            string s = Console.ReadLine();
            Regex reg = new Regex(@"^\d{3}.\d{3}.(\d{3}|\d{2}|\d{1}).(\d{3}|\d{2}|\d{1})$");
            if (reg.IsMatch(s))
            {
                Console.WriteLine("IP地址格式正确");
            }
            else
            {
                Console.WriteLine("IP地址格式错误");
            }

        }
       

    }
}
