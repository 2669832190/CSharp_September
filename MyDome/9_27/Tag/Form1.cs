using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tag {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void open_ClickORoff_Click(object sender , EventArgs e) {
            foreach (Control item in this.Controls)
            {
				Button button = sender as Button;

				if ( ) {
					PictureBox pictureBox = item as PictureBox;
					//pictureBox.Image = Image.FromFile(@"./宝箱2.png");
					//pictureBox.Tag = "true";
					pictureBox.Image = Image.FromFile(button.Name == "open" ? @"./宝箱2.png" : @"./宝箱1.png");
					pictureBox.Tag = button.Name == "open" ? "true" : "false";
					break;
				}
            }
        }


		private void off_Click(object sender , EventArgs e) {

		}
	}
}
