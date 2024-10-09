using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_26 {
	public partial class 多线程 : Form {
		public 多线程() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			a();
		}

		private void a() {
            Console.WriteLine("当前处理函数的线程是"+ Thread.CurrentThread.Name);
            //线程休眠5000毫秒
            Thread.Sleep(5000);
            Console.WriteLine(Thread.CurrentThread.Name + "函数运行完毕");
            MessageBox.Show("运行结束");

		}

		private void button2_Click(object sender , EventArgs e) {
			
			//创建委托实例
			ThreadStart ts = new ThreadStart(a);
			//创建一个线程，告知它运行什么任务
			Thread th = new Thread(a);
			th.Name = "线程1";

			//设置为后台线程
			th.IsBackground = true;
			//线程开始运行，主程序继续往下执行
			th.Start();
			MessageBox.Show("运行开始");
		}

		private void 多线程_Load(object sender , EventArgs e) {
			Thread.CurrentThread.Name = "主线程";
		}
	}
}
