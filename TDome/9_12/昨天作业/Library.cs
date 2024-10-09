using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 昨天作业
{
    //图书馆
    public class Library
    {
        private List<Book> list = new List<Book>();

        //在构造里生成几本书
        public Library()
        {
            Book book1 = new Book() { ID = 1, Name = "十万个为什么", Classification = "文学", DayPrice = 0.2, Price = 35.8 };
            Book book2 = new Book() { ID = 2, Name = "海底两万里", Classification = "冒险", DayPrice = 0.5, Price = 29.9 };
            Book book3 = new Book() { ID = 3, Name = "西游记", Classification = "神话", DayPrice = 0.3, Price = 59.9 };
            //添加到list
            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
        }

        //打印所有图书信息 用于测试
        public void Print()
        {
            foreach(Book book in list)
            {
                Console.WriteLine($"ID:{book.ID},书名:{book.Name},分类:{book.Classification},每天价格:{book.DayPrice}," +
                    $"总价格:{book.Price},是否借出:{book.IsLend},借出日期:{book.LendDate},借出天数:{book.LendDays}");
            }
        }

        //借书
        public double BorrowBooks(string bookName,int day)
        {
            for(int i = 0; i < list.Count; i++)
            {
                //找到这本书 并且 书的借出状态为false
                if (list[i].Name == bookName && !list[i].IsLend)
                {
                    //计算价格
                    double money = day * list[i].DayPrice;

                    //改变书的状态
                    list[i].IsLend = true;
                    list[i].LendDate = DateTime.Now;
                    list[i].LendDays = day;

                    return money;
                }
            }

            //返回0代表没找到真本书
            return 0;
        }

        //还书
        //1. 没找到书 返回了0
        //2. 找到了书 没有超出书的价格 返回超出的3倍借书价格
        //3. 找到了数 超出了书的价格 返回书的价格
        public double ReturnBook(string bookName,string date)
        {
            for(int i = 0;i < list.Count;i++)
            {
                if(list[i].Name == bookName && list[i].IsLend)
                {
                    list[i].IsLend = false;
                    
                    //找到这本书 计算还书日期
                    DateTime dateTime = DateTime.Parse(date);
                    //拿到应还书日期
                    DateTime returnDate = list[i].LendDate.AddDays(list[i].LendDays);
                    //实际还书日期 - 应还书日期
                    TimeSpan timeSpan = dateTime - returnDate;
                    //应当补钱
                    if(timeSpan.TotalDays > 0)
                    {
                        //应当支付的钱
                        double money = timeSpan.TotalDays * list[i].DayPrice * 3;
                        //是否大于书的价格
                        if(money >= list[i].Price)
                        {
                            //返回书的价格
                            return list[i].Price;
                        }
                        return money;
                    }
                    
                }
            }

            return 0;
        }
    }
}
