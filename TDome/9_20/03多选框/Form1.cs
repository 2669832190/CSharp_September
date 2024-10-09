using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03多选框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hobby.Items.Add("蓝球");
            //MessageBox.Show($"里面有{hobby.Items.Count}项");

            //遍历已经选中的所有项
            /*foreach(string str in hobby.CheckedItems)
            {
                MessageBox.Show(str);
            }*/

            //当前选定项
            //MessageBox.Show(hobby.SelectedItem + "");
            //当前选定项的索引
            //MessageBox.Show(hobby.SelectedIndex + "");

            //通过索引获取内容
            //MessageBox.Show(hobby.Items[0] + "");
            //MessageBox.Show(hobby.CheckedItems[1] + "");

        }
    }
}
