using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05字节流
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //流 : 一组连续的数据 动态的写入或读出
            //字节流 : 以字节的方法

            //1.创建字节流
            FileStream fs = new FileStream("./new.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //2.创建一个字节数组 用于读写 缓存区
            byte[] buffer = new byte[1024 * 5];
            //3.读内容
            //Read(保存到哪去,从那个字节开始读,读多少个字节)
            //返回int类型 表示成功读取到多少个字节
            int num = fs.Read(buffer, 0, buffer.Length);

            Console.WriteLine($"成功读取到{num}个字节");

            //Encoding.Default.GetString(byte数组,从哪开始读,读多少个字节)
            string str = Encoding.UTF8.GetString(buffer, 0, num);
            Console.WriteLine(str);
            //4.释放内存
            fs.Close();
            fs.Dispose();

            /*
            //语法糖 写起来简单
            using (FileStream fs = new FileStream("./new.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //当大括号里面的代码运行完成后，会自动释放小括号号里的内存
                //2.创建一个字节数组 用于读写 缓存区
                byte[] buffer = new byte[1024 * 5];
                //3.读内容
                //Read(保存到哪去,从那个字节开始读,读多少个字节)
                //返回int类型 表示成功读取到多少个字节
                int num = fs.Read(buffer, 0, buffer.Length);

                Console.WriteLine($"成功读取到{num}个字节");

                //Encoding.Default.GetString(byte数组,从哪开始读,读多少个字节)
                string str = Encoding.UTF8.GetString(buffer, 0, num);
                Console.WriteLine(str);
            */
            
        }

        //复习1 : 字节读写文件
        private static void review1()
        {
            //以字节的方式读写
            //好处: 字节是内存单位 能读写所有类型的文件
            //坏处: 麻烦 如果只读写字符串 不推荐这种方式

            string str = "abcdefg";
            //字符串转为byte数组
            byte[] bytes = Encoding.Default.GetBytes(str);
            //写文件
            File.WriteAllBytes("./new.txt", bytes);


            //读文件
            byte[] readBytes = File.ReadAllBytes("./new.txt");
            //转为字符串
            string readStr = Encoding.Default.GetString(readBytes);
            Console.WriteLine(readStr);
        }

        //复习2 : 字符串读写文本文件
        private static void review2()
        {

            //写入字符串
            File.WriteAllText("./new.txt", "1234567890");

            //一行一行写入整个字符串数组
            string[] strs =
            {
                "张三",
                "李四",
                "王五"
            };
            File.WriteAllLines("./new.txt", strs);

            //全部读到一个字符串
            string str = File.ReadAllText("./new.txt");
            Console.WriteLine(str);

            //一行一行读到字符串数组里
            string[] strs1 = File.ReadAllLines("./new.txt");
            foreach (string s in strs1)
            {
                Console.WriteLine(s);
            }
        }
    }
}
