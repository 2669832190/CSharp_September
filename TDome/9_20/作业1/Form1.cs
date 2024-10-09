using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 作业1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //第一个字符
            char first = lamp.Text[0];
            //后面的字符串
            string behind = lamp.Text.Substring(1);
            //拼起来
            lamp.Text = behind + first;
        }
    }
}
