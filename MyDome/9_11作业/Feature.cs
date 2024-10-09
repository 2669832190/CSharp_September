using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11作业 {
	internal class Feature {
		/// <summary>
		/// 借书
		/// </summary>
		/// <param name="name">书名</param>
		/// <param name="day">要借阅的天数</param>
		public void BorrowBook(string name,int day,DateTime BeginDate,Stack stack) {
			for ( int i = 0; i < stack.Books.Length; i++ ) {
				if ( name == stack.Books[i].Name ) {
					if ( !stack.Books[i].IsLend ) {
						stack.Books[i].IsLend = true;
						stack.Books[i].BeginDate = BeginDate;
						stack.Books[i].EndDate = BeginDate.AddDays(day);
						double money = day * stack.Books[i].BorrowPrice;
						stack.Print(stack.Books[i]);
                        Console.WriteLine("借阅成功，请按时还书，如若超出，还将支付超出部分的借阅费（超出部分按照现解约费的三倍收取！）\n");
                        Console.WriteLine("您应支付借阅费：" + money + "元\n");
						break;
					} else {
						Console.WriteLine("您要借阅书已被借出！");
						break;
					}
				} else {
                    Console.WriteLine("本馆内暂无此书，请建议管理员添加此书籍！");
					break;
                }
			}
		}
		/// <summary>
		/// 还书
		/// </summary>
		/// <param name="name"></param>
		public void ReturnBook(string name , DateTime nowDat , Stack stack) {
			for ( int i = 0; i < stack.Books.Length; i++ ) {
				if ( stack.Books[i].IsLend ) {
					TimeSpan timeSpan = nowDat - stack.Books[i].EndDate;
					if ( timeSpan.TotalDays <= 0 ) {
						stack.Books[i].IsLend = false;
						Console.WriteLine();
						Console.WriteLine("还书成功！");
						break;
					} else {
						double Money = 3 * stack.Books[i].BorrowPrice * timeSpan.TotalDays;
						if ( Money >= stack.Books[i].BookPrice ) {
							stack.Books[i].Status = E_BookStatus.丢失;
							Console.WriteLine();
							Console.WriteLine("由于超出的借阅费大于或等于书的价格，本馆视为丢失，请支付书本的原价" + stack.Books[i].BookPrice + "元。");
							break;
						} else {
							stack.Books[i].Status = E_BookStatus.正常;
							Console.WriteLine();
							Console.WriteLine("由于超出的借阅时间，请支付超出部分的借阅费" + Money + "元。");
							stack.Books[i].IsLend = false;
							break;
						}
					}
				} else {
                    Console.WriteLine("书没有被借走！！！");
                }
			}
		}
	}
}