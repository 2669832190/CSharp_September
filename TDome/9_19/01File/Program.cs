using System;
using System.Collections.Generic;
//IO 文件操作 流操作 都要用到的命名空间
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //File文件操作的类
            //File.Create(路径); 创建或覆盖
            //File.Create("C:\\Users\\lenovo\\Desktop\\new.txt");

            //删除文件
            //@ 忽略转义符
            //File.Delete(@"C:\Users\lenovo\Desktop\new.txt");

            //复制 复制到的位置不能有同名文件 不能是个文件夹
            //File.Copy(@"C:\Users\lenovo\Desktop\new.txt", @"C:\Users\lenovo\Desktop\new1.txt");

            //移动
            //File.Move(@"C:\Users\lenovo\Desktop\new.txt", @"C:\Users\lenovo\Desktop\test\new1.txt");

        }
    }
}
