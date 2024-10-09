using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda表达式2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action act = () => { Console.WriteLine("Hello"); };
            act();

            Action<int> act2 = x => Console.WriteLine(x);
            act2(10);

            Action<int, int> act3 = (x, y) =>
            {
                int z = x + y;
                Console.WriteLine("x+y的结果是:" + z);
            };
            act3(15, 25);


            Func<string, int> fun1 = str => str.Length;
            int len = fun1("abcdeqwert");
            Console.WriteLine("返回出来的len结果是:" + len);

            Func<int, bool> fun2 = x =>
            {
                if (x % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };

            bool bl = fun2(11);
            Console.WriteLine("是否为偶数:" + bl);
        }

        //lambda表达式 拉姆达表达式
        // => 前端 箭头函数

        #region 没有参数的情况
        /*
        //没有名字 匿名函数
        () => {Console.WriteLine("Hello")};

        public static void T1()
        {
            Console.WriteLine("Hello");
        }
        */
        #endregion

        #region 有参数的情况

        /*
        //当参数只有一个的时候 可以不要小括号
        //int可以省略
        //代码体里只有一行代码的时候 大括号也能省略
        x => Console.WriteLine("x的值是:"+x);

        public static void T2(int x)
        {
            Console.WriteLine("x的值是:" + x);
        }
        */


        #endregion

        #region 有两个参数的情况

        /*
        (x, y) => 
            {
                int z = x + y;
        Console.WriteLine("x+y的结果是:" + z);
            };

    public static void T3(int x, int y)
    {
        int z = x + y;
        Console.WriteLine("x+y的结果是:" + z);
    }
        */

        #endregion

        #region 有返回值的情况
        /*
        //当只有一行代码时 return可以不写
        str => str.Length;

        public static int T4(string str)
        {
            return str.Length;
        }
        */
        #endregion

        #region 稍微复杂一点点

        /*
        x => 
        {
            if(x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        };

        //输入一个数字 返回是不是偶数
        //bool true表示是偶数 false表示不是偶数
        public static bool IsOuShu(int x)
        {
            if(x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        */

        #endregion
    }
}
