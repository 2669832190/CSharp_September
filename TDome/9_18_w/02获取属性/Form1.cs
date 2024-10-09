using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02获取属性
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取到TextBox1里面的值
            string str = textBox1.Text;
            //转换为int类型
            int y = Convert.ToInt32(str);
            //计算年龄
            int age = 2024 - y;
            MessageBox.Show($"计算成功!你的年龄是:{age}");
        }
    }
}
