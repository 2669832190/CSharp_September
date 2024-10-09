using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Times {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		//根据我们设定的间隔时间
		//每隔一段时间运行一次
		private void timer1_Tick(object sender , EventArgs e) {
			label1.Text = DateTime.Now.ToString();
		}

		private void timer2_Tick(object sender , EventArgs e) {
			label2.Text = DateTime.Now.ToString();
		}
	}
}
