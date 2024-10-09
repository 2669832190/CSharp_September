using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04Path
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = @"C:\Users\lenovo\Desktop\test\new.txt";
            //文件名+扩展名
            Console.WriteLine(Path.GetFileName(str));
            //文件名
            Console.WriteLine(Path.GetFileNameWithoutExtension(str));
            //扩展名
            Console.WriteLine(Path.GetExtension(str));
            //路径信息 到文件夹(目录)
            Console.WriteLine(Path.GetDirectoryName(str));
            //全部路径 完整路径
            Console.WriteLine(Path.GetFullPath(str));

        }
    }
}
