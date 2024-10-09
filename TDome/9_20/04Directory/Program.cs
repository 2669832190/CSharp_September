using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _04Directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //文件操作 File
            //文件夹操作 Directory

            //绝对路径 : D:\某文件夹\某文件夹\...
            //绝对路径相当于从 x球x国xx省xx市xx县xx镇xx村xx街xx号

            //相对路径 : 当前项目下\...
            //相对路径相当于 我们街xx号

            // ./ : 当前项目下/bin/Debug/
            //Directory.CreateDirectory("./new");

            //删除 没有此路径的情况 删除会报错
            //第二个参数填入true 表示删除此路径下所有子目录和文件
            //Directory.Delete("./new");
            //Directory.Delete("./new", true);

            //从哪来 到哪去(需要改名)
            //Directory.Move("./new1","./new2/new");

            //获取路径下的所有子文件夹
            /*string[] paths = Directory.GetDirectories(".\\new2");
            foreach (string path in paths)
            {
                Console.WriteLine(path);
            }*/

            //判断文件夹 是否存在
            //../ 上一层目录
            Console.WriteLine(Directory.Exists("../../bin/Debug/new2/new"));
            
        }
    }
}
