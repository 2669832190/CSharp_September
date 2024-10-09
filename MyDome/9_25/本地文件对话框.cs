using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_25 {
	public partial class 本地文件对话框 : Form {
		public 本地文件对话框() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			//对话框的标题
			ofd.Title = "请选择你要打开的文件";
			//初始目录
			ofd.InitialDirectory = @"H:\CSharp_September\MyDome\9_25";
			//文件筛选器 表示能打开什么类型的文件
			//描述 | 文件类型(文件类型后不可有除”|“以外的其他非法字符如：空格)
			ofd.Filter = "文本文件|*.txt|音频文件|*.mp3|视频文件|*.mp4";
			//能够选择多个文件
			ofd.Multiselect = true;
			//打开对话框
			ofd.ShowDialog();

			//弹窗显示文件路径
			string name = ofd.FileName;
			MessageBox.Show( name );

			string[] names = ofd.FileNames;
			string Names = "";
            foreach (string item in names)
            {
				Names += item + "\n";
            }
			MessageBox.Show(Names);
        }
	}
}
