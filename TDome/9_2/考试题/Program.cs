using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 考试题
{
    public enum Gender
    {
        男,
        女,
        武装直升机,
        沃尔玛塑料袋,
        未知
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int myInteger, myInteger2;
            string myString;
            myInteger = 17;
            myInteger2 = 36;
            myString = "mylnteger is";
            //mylnteger is17
            //mylnteger is1736
            //mylnteger is1736
            Console.WriteLine(myString + myInteger +
            myInteger2 + "\t\n");
            Console.ReadKey();

            //默认是double类型
            float f = 3.14;
            //加了双引号变成了字符串
            bool b = "false";

            double d = 12.30d;
            //char是字符
            char c = "ABCD";
            */
            /*
            int a = 5;
            //b = 5 , a = 6
            int b = a++;
            //c = 7 , a = 7
            int c = ++a;
            Console.Write("a =" + a + ", b =" + b);
            int.Parse(Console.ReadLine());
            */

            //结构 : 顺序结构 分支结构 循环结构
            //常量定义后无法再次赋值
            const int number = 20;
            //number = 30;

            const string path = "D:\\某某文件夹\\某某文件夹";
            const double pi = 3.14;

            //隐式类型 猜测类型
            var v = "3.14";

            //a=true  b=false
            //true && true
            //true
            //a && (a || !b)

            //true | (true & true)
            //true | true
            //true
            //a | (a & !b)


            //x = 6
            //9 + 8 + 7 = 24
            //x-- + x-- + x--

            //continue 跳过当次循环 继续下一次循环
            //break 跳出循环体 继续执行循环之外的代码
            //return 跳出整个函数
            //continue break return
            /*
                        while (true)
                        {
                            return;
                        }
                        Console.WriteLine("123");
            */

            //强制转换字符串不可取
            //int i = (int)"123";

            int x = 10;
            // 条件1 ? 条件2 ? 条件3 ? 全部为true : 条件3为false : 条件2为false :条件1为false
            int y = x < 50 ? x < 10 ? x < 5 ? 3 : 4 : ++x : x--;

            //!  非 取反 true变成false false变成true
            //&& 与 并且 两边都为true最终结果为true，否则为false
            //|| 或 或者 两边有一个为true最终结果为true，否则为false
            //!、 &&、 ||


            /*
                        for (定义变量;判断条件;循环每结束一次后的变量变化)
                        {
                            循环体;
                        }
            */


            /*
            int a = 5;

            //适合判断范围的情况
            if(a > 5)
            {

            }else if(a < 3)
            {

            }

            //适合判断相等的情况
            switch (a)
            {
                case 1:
                case 2:
                    代码体
                    break;
                case 3:
                    代码体
                    break;
                default:
                    代码体
                    break;
            }
            */

            //关键字在VS里显示为蓝色
            //int double bool if else for while switch case default break continue return
            //public static

            //枚举的声明和使用
            Gender gen = Gender.男;
        }
    }

}
