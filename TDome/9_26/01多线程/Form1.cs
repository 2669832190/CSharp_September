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

namespace _01多线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //进程 和 线程
        //线程是执行代码的最小单位 一个进程可以包含多个线程

        //我现在想买个烧饼 但是不要芝麻
        private void PickSesameSeeds()
        {
            //让当前线程休眠3000毫秒
            Thread.Sleep(10000);

            MessageBox.Show("芝麻挑完了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PickSesameSeeds();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //创建委托实例
            ThreadStart ts = new ThreadStart(PickSesameSeeds);
            //创建一个线程，告知他运行什么任务
            Thread th = new Thread(ts);

            //让线程进入就绪状态
            th.Start();

            MessageBox.Show("芝麻开始挑了");
        }
    }
}
