using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业2
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
            for (int i = 1; i <= 4; i++)
            {
                //声明按钮
                Button button = new Button();
                //调整参数
                button.Name = "btn" + i;
                button.Text = "按钮" + i;
                //位置
                button.Location = new Point(100 * i, 100);
                //添加事件
                button.Click += btn_click;
                //把按钮添加到窗体
                this.Controls.Add(button);
            }
        }

        //按钮点击事件
        private void btn_click(object sender, EventArgs e)
        {
            //拿到这个按钮
            Button btn = sender as Button;
            //按钮上的文本 btn.Text
            MessageBox.Show(btn.Text);
        }
    }
}
