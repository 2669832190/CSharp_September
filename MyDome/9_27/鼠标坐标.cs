using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_27 {
	public partial class 鼠标坐标 : Form {
		public 鼠标坐标() {
			InitializeComponent();
		}

		private void 鼠标坐标_MouseMove(object sender , MouseEventArgs e) {
			e.X.ToString(); e.Y.ToString();
		}
	}
}
