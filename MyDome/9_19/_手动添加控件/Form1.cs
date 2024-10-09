using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;

namespace _手动添加控件 {
	public partial class Form1 { //: Form {
		public Form1() {
			InitializeComponent();
			//AddButton();
		}

		/*
		 * private void AddButton() {
			Button button = new Button();
			button.Name = "btn1";
			button.Text = "这是新建的按钮";
			//设置按钮位置 new Point(x轴的位置，y轴的位置) 创建一个点的位置
			button.Location = new Point(80 , 30);
			//设置按钮大小 new Size(宽度，高度) 设置大小
			button.Size = new Size(200 , 50);
			//当前窗体.所有控件的集合.Add(需要添加进窗体的控件)
			this.Controls.Add(button);


			//委托多播
			button.Click += Btn_Click;
		}

		private void Btn_Click(object sender , EventArgs e) {
			MessageBox.Show("这个按钮被点击了");
		}
		*/
	}
}
