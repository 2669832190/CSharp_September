using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01初识winfrom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //当按钮被点击时 会触发这个方法
        private void button1_Click(object sender, EventArgs e)
        {
            //弹出一条提示
            MessageBox.Show("按钮被点击了!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new 一个 form2
            Form2 form2 = new Form2();
            //显示
            form2.Show();
        }
    }
}
