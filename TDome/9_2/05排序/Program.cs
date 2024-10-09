using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05排序
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 7, 5, 3, 2, 9, 8, 6, 10 };
            //Sort 升序
            //Array.Sort(arr);

            //封装一个方法 int类型的返回值 有两个参数
            //Comparison

            //1 5 3 2 7 8 6 9 10
            //1 3 2 5 7 6 8 9
            //1 2 3 5 6 7 8
            Array.Sort(arr, (x, y) => x - y);
            Array.ForEach(arr, x => Console.WriteLine(x));
            Console.WriteLine();

            //7 1 ...
            Array.Sort(arr, (x, y) => y - x);
            Array.ForEach(arr, x => Console.WriteLine(x));
        }
    }
}
