using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02单选按钮
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //如果man这个控件被选中 man.Checked结果为true
            if (man.Checked)
            {
                MessageBox.Show("性别为男");
            }else if (woman.Checked)
            {
                MessageBox.Show("性别为女");
            }

            if (sing.Checked)
            {
                MessageBox.Show("爱好是唱");
            }else if (jump.Checked)
            {
                MessageBox.Show("爱好是跳");
            }else if (rap.Checked)
            {
                MessageBox.Show("爱好是rap");
            }
        }
    }
}
