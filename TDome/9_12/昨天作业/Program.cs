using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    internal class Program
    {
        static Library library = new Library();

        static void Main(string[] args)
        {
            Console.WriteLine("欢迎来到图书馆!");

            //借书还书 死循环可以一直操作
            while (true)
            {
                //打印信息
                library.Print();

                Console.WriteLine("请输入要进行的操作:1.借书 2.还书 3.退出");
                int inputNum = Convert.ToInt32(Console.ReadLine());
                switch (inputNum)
                {
                    case 1:
                        BorrowBooks();
                        break;
                    case 2:
                        ReturnBook();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("输入的数字有误，请重新输入！");
                        break;
                }

            }
        }

        //专门用于处理借书的方法
        static void BorrowBooks()
        {
            Console.WriteLine("请输入要借的书名:");
            //书名
            string bookName = Console.ReadLine();
            Console.WriteLine("请输入要借的天数:");
            //借的天数
            int day = Convert.ToInt32(Console.ReadLine());

            //得交给图书馆处理
            double money = library.BorrowBooks(bookName, day);

            if(money == 0)
            {
                Console.WriteLine("没有找到这本书或这本书已经被借出！");
            }
            else
            {
                Console.WriteLine($"借书成功，需支付{money}元");
            }
        }

        //专门用于处理还书的方法
        static void ReturnBook()
        {
            Console.WriteLine("请输入要还的书名:");
            string bookName = Console.ReadLine();
            Console.WriteLine("请输入还书日期:");
            string date = Console.ReadLine();

            //还书交给图书馆处理
            double money = library.ReturnBook(bookName, date);
            if(money == 0)
            {
                Console.WriteLine("没有找到这本书或者没有被借出");
            }
            else
            {
                Console.WriteLine($"应当支付{money}钱");
            }
        }
    }
}
