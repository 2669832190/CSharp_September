using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_18_Winfomestart {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Trial_Run(object sender , EventArgs e) {
			//信息弹窗
			MessageBox.Show("按钮被点击了");
		}

		private void button2_Click(object sender , EventArgs e) {
			//在Form中 new 一个新的窗体
			Form2 form = new Form2();
			//new 完以后直接展示当前窗体
			form.Show();
		}

		private void button3_Click(object sender , EventArgs e) {
			//关闭当前窗体
			this.Close();
		}
	}
}
