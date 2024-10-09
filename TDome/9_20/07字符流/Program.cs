using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07字符流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 创建读的字符流
            //方便 但是只能读文本
            using (StreamReader sr = new StreamReader("./new.txt",Encoding.UTF8))
            {
                //sr.ReadToEnd() 读到结尾
                //Console.WriteLine(sr.ReadToEnd());
                //读一行
                //Console.WriteLine(sr.ReadLine());

                //没有到流的结尾 开始读
                //while (!sr.EndOfStream)
                {
                    //Console.WriteLine(sr.ReadLine());
                }
            }

            //写文本 true追加 false覆盖
            using (StreamWriter sw = new StreamWriter("./new.txt",false))
            {
                sw.Write("qwerty");
            }
        }
    }
}
