using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 周六作业
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //T1();
            //T2();
            //int miao = T3(2, 20, 30);
            //Console.WriteLine("接收到的秒数是:" + miao);
            //T4();

            #region ASCII码
            //字符0  数字0
            //'0'  0
            //当字符转换为int值时 会按照ASCII码编号转换 字符'0'对应编号48
            //Console.WriteLine((int)'1');
            //int类型的值转换为字符的时候 会根据ACII码表 转换为对应的字符
            //Console.WriteLine((char)50);
            #endregion
            /*
            'a' >= '0' && 'a' <= '9'
            97 >= 48 && 97 <= 57 
            true && false == false

            '6' >= '0' && '6' <= '9'
            54 >= 48 && 54 <= 57
            true && true == true
            */


            //T5(new int[] { 1, 2, 3, 4, 5, 6 }, Ergodic);
            //T6();
            /*
            int[][] ints =
            {
                new int[]{1,2,3},
                new int[]{4,5,6,7},
                new int[]{12,13 }
            };
            printArr(ints);
            */

            //T8(9);

            int n = T9(10);
            Console.WriteLine("n的结果是:" + n);
        }

        #region 1-5题
        //1. 在一个double数组中，输出其中的正整数。
        public static void T1()
        {
            double[] doubles = { 1.2, 2.4, 3, 4.6, 6.0, -2.5, -8 };
            //遍历
            for (int i = 0; i < doubles.Length; i++)
            {
                //查找正整数
                if (doubles[i] > 0 && doubles[i] % 1 == 0)
                {
                    Console.Write(doubles[i] + " ");
                }
            }
        }

        //2. 输入10个学生的成绩，输出高于平均分的学生成绩。
        public static void T2()
        {
            double[] score = new double[10];

            for (int i = 0; i < score.Length; i++)
            {
                //i为0时 是第1个人成绩
                Console.WriteLine("请输入第" + (i + 1) + "个人的成绩");
                //第i项成绩
                score[i] = Convert.ToDouble(Console.ReadLine());
            }

            //计算总和
            double number = 0;
            foreach (double i in score)
            {
                //number 加上 i 的值
                number += i;
            }
            //计算平均分
            double ave = number / 10;
            Console.WriteLine("平均分是:" + ave);

            for (int i = 0; i < score.Length; i++)
            {
                //如果第i项成绩大于平均分 输出第i项成绩
                if (score[i] > ave)
                {
                    Console.WriteLine(score[i]);
                }
            }
        }

        //3. 写一个方法，输入3个整数，分别表示时分秒，返回 这个时间是今天的第几秒。
        //三个参数 分别表示时分秒
        public static int T3(int h, int m, int s)
        {
            int miao = h * 3600 + m * 60 + s;
            return miao;
        }

        //4. 输入一个字符串，统计 其中有多少个数字字符。
        //例：Today is 2024-08-30
        //答：数字字符一共8个
        public static void T4()
        {
            Console.WriteLine("请输入一个字符串:");
            string str = Console.ReadLine();

            //创建一个变量 用于记录有几个数字
            int count = 0;

            //通过ASCII码来判断
            for (int i = 0; i < str.Length; i++)
            {

                if (str[i] >= '0' && str[i] <= '9')
                {
                    count++;
                }
            }
            Console.WriteLine("一共有" + count + "个数字");
        }

        //5. 编写一个函数，接收一个数组和一个用来遍历数组的函数
        //使用这个函数遍历一个数组
        public static void T5(int[] ints, Action<int[]> fangFa)
        {
            fangFa(ints);
        }

        //传入一个数组 遍历这个数组
        public static void Ergodic(int[] ints)
        {
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
        #endregion

        #region 4-8题

        //6. 从1输出到100，当遇到7的倍数、个位为7的数、十位为7的数时，跳过这个数
        public static void T6()
        {
            //逢七过
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 == 0 || i % 10 == 7 || i / 10 == 7)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        /*
         * 写一个方法，传入一个交错数组，能够将其以美观的形式输出到控制台
         * 例：
                [
                    [1,2,3,4],
                    [5,6,7,8,9,10]
                ]
         */
        public static void printArr(int[][] ints)
        {
            Console.WriteLine("[");

            //ints.Length 表示ints里有几个一维数组
            for (int i = 0; i < ints.Length; i++)
            {
                Console.Write("\t[");

                //ints[i].Length 表示每个一维数组的长度
                for (int j = 0; j < ints[i].Length; j++)
                {
                    //如果已经是这个数组的最后一个数，就不要逗号
                    if (j == ints[i].Length - 1)
                    {
                        Console.Write(ints[i][j]);
                    }
                    else
                    {
                        Console.Write(ints[i][j] + ",");
                    }
                }

                //每个数组结束的时候
                //如果已经是最后一个数组，不打印逗号
                if (i == ints.Length - 1)
                {
                    Console.WriteLine("]");
                }
                else
                {
                    Console.WriteLine("],");
                }
            }


            Console.WriteLine("]");
        }

        //8. 写一个方法，输入一个数，返回比这个数大的第一个能被7整除的数
        public static void T8(int n)
        {
            //这个数先+1
            //判断能不能被7整除
            //不能整除就再+1
            //判断能不能被7整除
            /*
            n++;
            while(n % 7 != 0)
            {
                n++;
            }
            */
            /*
            do
            {
                n++;
            } while (n % 7 != 0);
            */

            //9 / 7 == 1
            //7 / 7 == 1
            int m = n / 7;

            Console.WriteLine((m + 1) * 7);
        }
        #endregion

        //9.  斐波那契数列，第一个数是1，第二个数是1，从第三个数起，每个数等于前两个数之和
        //例: 1,1,2,3,5,8,13,21,34,55
        //写一个方法，输入一个数，返回斐波那契数列中第{这个数}的值
        public static int T9(int n)
        {
            int[] arr = new int[n];
            //前两个数
            arr[0] = 1;
            arr[1] = 1;

            for (int i = 2; i < arr.Length; i++)
            {
                //arr[2] = arr[1] + arr[0]  = 2
                //arr[3] = arr[2] + arr[1]  = 2 + 1 = 3
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            //假如数组长度为10 最后一个的索引是9
            return arr[n - 1];
        }
    }
}
