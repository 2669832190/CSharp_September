using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05手动添加控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AddBtn();
        }

        private void AddBtn()
        {
            //添加一个按钮
            Button btn1 = new Button();
            //改Name
            btn1.Name = "btn1";
            //文本
            btn1.Text = "这是个新建的按钮";
            //new Point(X轴位置，Y轴位置) 创建一个点的位置
            btn1.Location = new Point(80, 30);
            //new Size(宽度，高度)  创建一个大小
            btn1.Size = new Size(200, 50);

            //委托多播
            btn1.Click += Btn_click;

            //当前窗体.所有控件的集合.Add(需要添加进窗体的控件)
            this.Controls.Add(btn1);
        }


        //object sender 这个按钮本身
        //EventArgs e  其他的相关数据
        private void Btn_click(object sender, EventArgs e)
        {
            //拿到这个按钮本身
            Button btn = sender as Button;

            MessageBox.Show("这个按钮被点击了");
        }
    }
}
