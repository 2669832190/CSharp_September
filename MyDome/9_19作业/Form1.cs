using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_19作业 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
			AddBtn();
			AddBtn(1);
		}

		#region 第一题
		int num = 0;
		bool Istrue = true;
		string[] strings = new string[3]{
		"☆",
		"☆",
		"☆"
		};
		string[] temp = new string[3];
		private void Form1_Load(object sender , EventArgs e) {
			for ( int i = 0; i < strings.Length; i++ ) {
				temp[i] = strings[i];
			}
			temp[num] = "★";
			for ( int i = 0; i < 7; i++ ) {
				for ( int j = 0; j < strings.Length; j++ ) {
					label1.Text += temp[j];
				}
			}
		}
		private void change() {
			if ( !Istrue ) {
				if ( num == 0 ) {
					num = strings.Length - 1;
				} else {
					num--;
				}
			} else {
				if ( num == strings.Length - 1 ) {
					num = 0;
				} else {
					num++;
				}
			}
			for ( int i = 0; i < strings.Length; i++ ) {
				temp[i] = strings[i];
			}
			temp[num] = "★";
			label1.Text = null;
			for ( int i = 0; i < 7; i++ ) {
				for ( int j = 0; j < strings.Length; j++ ) {
					label1.Text += temp[j];
				}
			}
		}
		private void timer1_Tick(object sender , EventArgs e) {
			change();
		}
		private void AddBtn(int a) {
			for ( int i = 0; i < 2; i++ ) {
				Button button = new Button();
				if ( i == 0 ) {
					button.Text = "👈";
					button.Name = "left";
					button.Location = new Point(200 , 140);
					button.Size = new Size(50 , 50);
					button.Click += click;
				} else {
					button.Text = "👉";
					button.Name = "right";
					button.Location = new Point(350 , 140);
					button.Size = new Size(50 , 50);
					button.Click += click;
				}
				this.Controls.Add(button);
			}
		}
		private void click(object sender , EventArgs e) {
			Button button = sender as Button;
			if ( button.Name == "left" ) {
				Istrue = false;
			} else {
				Istrue = true;
			}
		}
		#endregion

		#region 第二题
		int index = 1;
		private void AddBtn() {
			for ( int i = 0; i < 4; i++ ) {
				Button button = new Button();
				button.Name = "按钮" + index;
				button.Text = "按钮" + index;
				button.Location = new Point(( index - 1 ) * 100 + 125 , index + 280);
				button.Size = new Size(50 , 50);
				button.Click += Click;
				this.Controls.Add(button);
				index++;
			}
		}
		private void Click(object sender , EventArgs e) {
			Button button = (Button)sender;
			MessageBox.Show(button.Text);
		}
		
		#endregion

		
	}
}
