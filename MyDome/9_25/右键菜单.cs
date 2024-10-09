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
	public partial class 右键菜单 : Form {
		public 右键菜单() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			//挂载
			this.ContextMenuStrip = contextMenuStrip1;
		}

		private void button2_Click(object sender , EventArgs e) {
			this.ContextMenuStrip = contextMenuStrip2;
		}

		private void Form3_Load(object sender , EventArgs e) {
			this.ContextMenuStrip = contextMenuStrip3;
		}

		private void ToolStripMenuItem_Click(object sender , EventArgs e) {
			//当点击右键菜单时发生的事情！
			MessageBox.Show("点击了右键菜单中的"+ sender.ToString());
		}
	}
}
