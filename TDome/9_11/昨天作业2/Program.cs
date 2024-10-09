using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            //添加
            list.Add(1);
            list.Add(2);
            list.Add(3);
            //删除
            list.Remove(1);

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine("=======");

            Console.WriteLine(list.Contains(2));
            Console.WriteLine(list.Contains(1));

            //清空数组
            list.Clear();
            Console.WriteLine(list.Count);

        }
    }
}
