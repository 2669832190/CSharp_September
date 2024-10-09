using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07动态数组
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //我们之前用到的数组 声明的时候必须声明长度
            int[] arr = new int[10];

            //动态数组 不需要声明长度
            //动态数组在存储的过程中 进行了装箱操作
            ArrayList list = new ArrayList()
            {
                1,
                "123",
                true,
                'a',
                2.5,
                new int[]{1,2,3}
            };
            //取出来值的过程 需要拆箱
            int i = (int)list[0];
            string s = (string)list[1];

            //Add 添加一个元素
            list.Add(20);
            //ArrayList通过.Count获取里面有多少个元素
            Console.WriteLine(list.Count);

            //删除
            //指定内容删除
            list.Remove(2.5);
            Console.WriteLine(list.Count);
            //指定位置删除
            list.RemoveAt(2);
            Console.WriteLine(list[2]);
            //颠倒数组
            list.Reverse();
            Console.WriteLine(list[2]);
            //查询值对应的索引
            Console.WriteLine(list.IndexOf("123"));
            //查询值是否存在
            Console.WriteLine(list.Contains(20));

        }
    }
}
