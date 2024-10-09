using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03下拉框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> list = new List<string>() { "鱼香肉丝", "麻婆豆腐", "红烧肉", "蒸熊掌" };
        private void Form1_Load(object sender, EventArgs e)
        {
            //dish.Items.Add("内容");  添加一项
            foreach (string item in list)
            {
                dish.Items.Add(item);
            }
        }

        //选中的内容发生改变时
        private void dish_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("当前选择的菜是:" +dish.SelectedItem.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清空内容
            dish.Items.Clear();
        }
    }
}
