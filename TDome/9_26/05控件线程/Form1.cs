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

namespace _05控件线程
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Action 没有参数 没有返回值的委托
            //lambda表达式 
            Action ac = () =>
            {
                listBox1.Items.Add("蔡徐坤");
            };

            //异步 同步
            //在listBox1的线程中异步运行ac的方法
            listBox1.BeginInvoke(ac);
        }


        //ac等同于下面的方法
        private void listBox1Add()
        {
            //假设添加条信息 需要进行一些处理 需要时间
            Thread.Sleep(3000);
            listBox1.Items.Add("蔡徐坤");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
