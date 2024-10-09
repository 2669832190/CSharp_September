using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06MDI容器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //MDI : 多文档界面 ， 允许同时操作多个子窗口
        private void 创建2号3号4号窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //创建窗体
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();
            //让这些窗体 认个爹
            form2.MdiParent = this;
            form3.MdiParent = this;
            form4.MdiParent = this;
            //显示这些窗体
            form2.Show();
            form3.Show();
            form4.Show();
        }

        private void 垂直布局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 水平布局ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }

}
