using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_11作业 {
	/// <summary>
	/// 书籍分类
	/// </summary>
	public enum E_BookSort {
		军事,	
		地理,	
		文学,	
		哲学,	
		经济	
	}
	/// <summary>
	/// 书的状态
	/// </summary>
	public enum E_BookStatus { 
		丢失,
		正常
	}
	/// <summary>
	/// 书库
	/// </summary>
	public class Stack {
		public Book[] Books = new Book[0];
		public void Add(Book book) {
			Array.Resize(ref Books , Books.Length + 1);
			Books[Books.Length - 1] = book;
		}
		public void Remove(int ID) {
			Array.Copy(Books , ID + 1 , Books , ID ,Books.Length - (ID + 1));
			Array.Resize(ref Books , Books.Length - 1);
		}
		public static void maina(Stack stack) {
			Book book01 = new Book("孙子兵法",E_BookSort.军事,0.2,20);
			Book book02 = new Book("二战风云4：地狱之门",E_BookSort.军事,0.4,49.8);
			Book book03 = new Book("地理学思想经典解读",E_BookSort.地理,0.4,49);
			Book book04 = new Book("地理学思想史",E_BookSort.地理,0.5,55);
			Book book05 = new Book("三国演义",E_BookSort.文学,0.3,39.5);
			Book book06 = new Book("红楼梦",E_BookSort.文学,0.5,59.7);
			Book book07 = new Book("中国哲学史",E_BookSort.哲学,0.72,72);
			Book book08 = new Book("老子的哲学",E_BookSort.哲学,0.5,52.8);
			Book book09 = new Book("国富论",E_BookSort.经济,0.6,62);
			Book book10 = new Book("政治经济学概论",E_BookSort.经济,0.4,42);
			stack.Add(book01);
			stack.Add(book02);
			stack.Add(book03);
			stack.Add(book04);
			stack.Add(book05);
			stack.Add(book06);
			stack.Add(book07);
			stack.Add(book08);
			stack.Add(book09);
			stack.Add(book10);
		}
		public void Print(Book item) {
            Console.WriteLine();
            Console.WriteLine("您的借书信息如下：");
			Console.WriteLine("ID："+item.ID + " 书名：《" + item.Name + "》 书籍分类：" + item.Sort + "类\n\n借阅价格：" + item.BorrowPrice
					+ " 书本价格：" + item.BookPrice + "\n\n借出日期：" + item.BeginDate.ToString("yyyy年MM月dd日")
					+ " 规定还书日期：" + item.EndDate.ToString("yyyy年MM月dd日\n\n"));
		}
		public void Print() {
			foreach ( Book item in Books ) {
				Console.WriteLine("ID：" + item.ID + "\t书名：《" + item.Name + "》\t书籍分类：" + item.Sort + "类\t借阅价格：" + item.BorrowPrice
					+ "\t书本价格：" + item.BookPrice + "\t是否借出：" + item.IsLend+"\t书籍状态："+item.Status+ "\n\n");
			}
		}
	}
	/// <summary>
	/// 书
	/// </summary>
	public class Book {
		public int ID { get; set; }
		public static int Id { get; set; } = 0;
		public string Name { get; set; }
		public E_BookSort Sort { get; set; }
		public double BorrowPrice { get; set; }
		public double BookPrice { get; set; }
		public bool IsLend { get; set; }
		public DateTime BeginDate { get; set; }
		public DateTime EndDate { get; set; }
		public E_BookStatus Status { get; set; }
		public Book(string Name , E_BookSort Sort , double BorrowPrice , double BookPrice) {
			this.Name = Name;
			this.Sort = Sort;
			this.BorrowPrice = BorrowPrice;
			this.BookPrice = BookPrice;
			Id++;
			ID = Id;
			Status = E_BookStatus.正常;
		}
	}
}