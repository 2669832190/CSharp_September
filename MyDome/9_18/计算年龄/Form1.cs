using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算年龄 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			int year = int.Parse(textBox1.Text);
			//MessageBox.Show(DateTime.Now.Year.ToString());
			int age = DateTime.Now.Year - year;
			MessageBox.Show(age.ToString());

		}

		private void button2_Click(object sender , EventArgs e) {
			this.Close();
		}
	}
}
