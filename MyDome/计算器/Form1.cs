using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器 {

	

	public partial class Calculator : Form {

		double x= 0;
		double y=0;
		
		/// <summary>
		/// 接受点击运算符后的数字
		/// </summary>
		double Value = 0;
		//判断是否需要添加num
		bool IsNextNum = false;
		/// <summary>
		/// 接受点击的数字
		/// </summary>
		string count = null;

		/// <summary>
		/// 运算符
		/// </summary>
		string operatornned;

		public Calculator() {
			InitializeComponent();
		}
		/// <summary>
		/// 数字点击
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Num_Click(object sender , EventArgs e) {
			
			Button button = sender as Button;
			count += "" + button.Text;
			Num.Text = count.ToString();
		}
		/// <summary>
		/// 点击运算符
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Operator_Click(object sender , EventArgs e) {

			Button button = sender as Button;
			operatornned = button.Text;
			
			//Num.Text = button.Text;
			if ( !IsNextNum ) {
				x = double.Parse(count);
				IsNextNum = true;
				count = null;

				Tips.Text = x.ToString() + button.Text.ToString();
				//Tips.Text = button.Text.ToString() + x.ToString();
			} else {
				y = double.Parse(count);
				count = null;
				//计算前两个数的和
				switch ( operatornned ) {
					case "+":
						Value = x + y;
						x = Value;
						break;
					case "-":
						Value = x - y;
						x = Value;
						break;
					case "*":
						Value = x * y;
						x = Value;
						break;
					case "/":
						Value = x / y;
						x = Value;
						break;
				}
				Tips.Text = x.ToString() + button.Text.ToString();
				//Tips.Text = button.Text.ToString() + x.ToString();
			}
		}
		/// <summary>
		/// 正变负
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button8_Click(object sender , EventArgs e) {
			count = "-" + count;
			Num.Text = "-"+ Num.Text.ToString();
		}
		/// <summary>
		/// 计算！
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender , EventArgs e) {
			y = double.Parse(count);
			//计算
			switch ( operatornned ) {
				case "+":
					Value = x + y;
					break;
				case "-":
					Value = x - y;
					break;
				case "*":
					Value = x * y;
					break;
				case "/":
					Value = x / y;
					break;
			}
			Tips.Text = x.ToString() + " + " + y.ToString() + "=";
			Num.Text = Value.ToString();
		}
		/// <summary>
		/// 清除
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button4_Click(object sender , EventArgs e) {
			x = 0;
			y = 0;
			Value = 0;
			IsNextNum = false;
			count = null;
			operatornned = null;
			Num.Text = "0";
			Tips.Text = null;
		}
	}
}
