using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05本地文件对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //创建一个对话框控件
            OpenFileDialog ofd = new OpenFileDialog();
            //对话框标题
            ofd.Title = "选择你要打开的文件";
            //初始目录
            ofd.InitialDirectory = @"C:\";
            //文件筛选器 表示能打开什么类型的文件
            //描述 | 文件类型
            ofd.Filter = "文本文件|*.txt|音频文件|*.mp3";
            //能够选择多个文件
            ofd.Multiselect = true;
            //打开对话框
            ofd.ShowDialog();

            //我们在选择打开文件后 打开的文件路径
            string name = ofd.FileName;
            MessageBox.Show(name);

            string[] names = ofd.FileNames;
            string path = "";
            //遍历打开的文件的所有路径
            foreach (string s in names)
            {
                path += s + "\n";
            }
            MessageBox.Show(path);

            //字符流 进行读写 略
        }
    }
}
