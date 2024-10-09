using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04右键菜单
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //挂载右键菜单
        private void Form1_Load(object sender, EventArgs e)
        {
            //当前窗体的右键菜单 = 我们刚才创建的菜单
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了复制");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ContextMenuStrip = contextMenuStrip2;
        }
    }
}
