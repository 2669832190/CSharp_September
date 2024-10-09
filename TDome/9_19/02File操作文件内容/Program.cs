using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引用IO命名空间
using System.IO;

namespace _02File操作文件内容
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //byte 读写 可以读写任何文件
            //读写字符串的时候 稍微麻烦
            string str = "123456";
            //字符串转为字节数组
            //Encoding.Default 默认字符编码
            //.GetBytes(字符串) 将字符串转为对应编码的字节数组
            byte[] bytes = Encoding.Default.GetBytes(str);

            //写文件 覆盖写进C:\Users\lenovo\Desktop\test\new.txt
            File.WriteAllBytes(@"C:\Users\lenovo\Desktop\test\new.txt", bytes);

            //读文件
            byte[] readByte = File.ReadAllBytes(@"C:\Users\lenovo\Desktop\test\new.txt");
            
            //字节数组转为字符串
            string readStr = Encoding.Default.GetString(readByte);
            Console.WriteLine(readStr);

            //字节 内存单位
            //1byte = 8bit  1字节 = 8位
            //1KB = 1024byte
            //1MB = 1024KB
            //1GB = 1024MB
            //1TB = 1024GB
            //1PB = 1024TB  EB ZB YB
        }
    }
}
