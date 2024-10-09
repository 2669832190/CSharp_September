using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 周六作业1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("请输入一个菜名，用于添加:");
            string name = Console.ReadLine();
            //添加菜名
            using(StreamWriter sw = new StreamWriter("./menu.txt", true))
            {
                sw.WriteLine(name);
                Console.WriteLine("添加菜名成功!");
            }
            */
            printMenu();
            Console.WriteLine("请输入一个菜名，用于删除:");
            string name = Console.ReadLine();
            //创建一个List，用于保存所有的菜名
            List<string> list = new List<string>();
            //遍历文本文件，将菜名添加到list
            using (StreamReader sr = new StreamReader("./menu.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    list.Add(sr.ReadLine());
                }
            }
            //找到要删除的菜名
            bool result = list.Remove(name);
            if (result)
            {
                Console.WriteLine("删除成功");
            }
            else
            {
                Console.WriteLine("删除失败，没有找到");
            }

            //遍历list，覆盖写入文本
            using (StreamWriter sw = new StreamWriter("./menu.txt", false))
            {
                foreach (string s in list)
                {
                    sw.WriteLine(s);
                }
            }

            printMenu();
        }

        private static void printMenu()
        {
            //字符流
            using (StreamReader sr = new StreamReader("./menu.txt", Encoding.UTF8))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
        }
    }
}
