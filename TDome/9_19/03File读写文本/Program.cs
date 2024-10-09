using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03File读写文本
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] strs = new string[]
            {
                "王五",
                "李四",
                "张三"
            };*/

            //C:\Users\lenovo\Desktop\test\new.txt
            //将字符串数组中的所有内容 一行一行写入
            //File.WriteAllLines(@"C:\Users\lenovo\Desktop\test\new.txt", strs);

            //覆盖写入一行字符串
            //File.WriteAllText(@"C:\Users\lenovo\Desktop\test\new.txt","坤坤");

            //追加字符串 不覆盖
            //File.AppendAllText(@"C:\Users\lenovo\Desktop\test\new.txt", "坤坤");

            //读
            //一行一行读到一个字符串数组里
            /*
            string[] strs = File.ReadAllLines(@"C:\Users\lenovo\Desktop\test\new.txt");
            
            foreach (string str in strs)
            {
                Console.WriteLine(str);
            }
            */

            //全部读到一起
            string newStr = File.ReadAllText(@"C:\Users\lenovo\Desktop\test\new.txt");

            Console.WriteLine(newStr);
        }
    }
}
