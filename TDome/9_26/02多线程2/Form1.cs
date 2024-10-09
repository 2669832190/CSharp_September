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

namespace _02多线程2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //获取到主线程
            Thread thread = Thread.CurrentThread;
            //改个名字
            thread.Name = "主线程";
        }

        //给草莓挑籽
        private void StrawberrySeedPicking()
        {
            //快速的给草莓挑个籽
            Console.WriteLine($"当前给草莓挑籽的线程是:{Thread.CurrentThread.Name}");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.Name}挑籽完成");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StrawberrySeedPicking();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //直接创建线程 在构造函数里填入运行的方法
            Thread th = new Thread(StrawberrySeedPicking);
            //给分线程一个名字
            th.Name = "线程1";

            //设置为后台线程 当主线程死亡死 后台线程也停止运行
            th.IsBackground = true;

            //开始运行
            th.Start();
        }
    }
}
