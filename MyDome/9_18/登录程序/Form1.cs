using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 登录程序 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			string UserName = textBox1.Text;
			string Password = textBox2.Text;
			if ( UserName == "admin" && Password == "123456" ) {
				MessageBox.Show("登录成功");
			} else {
				MessageBox.Show("登录失败");
			}
		}
	}
}
