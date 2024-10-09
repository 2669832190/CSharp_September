using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04数组查询
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //封装(代理)一个函数 必须没有返回值 参数可以有
            //Action<参数类型>
            //封装(代理)一个函数 必须有返回值 参数可以有
            //Func<参数类型,返回值类型>
            //封装(代理)一个函数 必须有布尔类型的返回值 有一个参数
            //Predicate<int> pre = find;



            int[] arr = { 5, 4, 8, 3, 9, 1, 2, 3 };
            //Find 查询与指定谓词匹配的第一个结果
            //int x = Array.Find(arr,find);
            int num = Array.Find(arr, y => y < 3);
            //FindAll 查询所有匹配的元素
            int[] ints = Array.FindAll(arr, x =>
            {
                if (x < 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
            
            //FindIndex 查找第一个匹配的元素 返回索引
            int index = Array.FindIndex(arr, x => x == 1);
            Console.WriteLine("查找到的第一个匹配的值的索引是:" + index);
            //FindLast 查找最后一个匹配的元素
            //Array.FindLast();
            //FindLastIndex 查找最后一个匹配的元素 返回索引
            //Array.FindLastIndex();

            //ForEach 遍历数组
            Array.ForEach(arr, x => Console.WriteLine(x));
        }

        public static bool find(int x)
        {
            return x < 3;
        }

        public static bool findall(int x)
        {
            if (x < 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
