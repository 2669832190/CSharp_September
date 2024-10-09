using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_ {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		int begin = 0;
		int end = 1000;
		
		private void button1_Click(object sender , EventArgs e) {
			Graphics graphics = this.CreateGraphics();

			Pen pen = new Pen(Color.Black,1);

			for ( int i = 0; i < end; i++ ) {
				if ( begin != end ) {
					Point point = new Point(begin,begin - i*20);
					Point point1 = new Point(begin,1000);
					begin += 20;
					graphics.DrawLine(pen , point , point1);
				} else {
					break;
				}
				
			}
		}
	}
}
