using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06索引器练习
{
    //鸟
    public class Bird
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Call()
        {
            Console.WriteLine("鸟开始叫");
        }
    }
}
