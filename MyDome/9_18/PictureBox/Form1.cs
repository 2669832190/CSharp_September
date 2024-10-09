using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBox {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		//窗体加载
		private void Form1_Load(object sender , EventArgs e) {
			//图片的相对路径：当前项目的bin\Debug目录为起始位
			Image image = Image.FromFile("img:\\1.jpg");
			//赋值给图片控件
			pictureBox1.Image = image;
		}
	}
}
