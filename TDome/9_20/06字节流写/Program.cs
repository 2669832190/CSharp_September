using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06字节流写
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.创建字节流
            using (FileStream fs = new FileStream("./new.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                string str = "红豆生长在阳光明媚的南方，每逢春天不知长多少新枝。\r\n希望思念的人儿多多采摘，因为它最能寄托相思之情。";
                byte[] bytes = Encoding.UTF8.GetBytes(str);
                //Write(往里写的内容,从哪开始写,写多少个字节)
                fs.Write(bytes, 0, bytes.Length);
            }
        }
    }
}
