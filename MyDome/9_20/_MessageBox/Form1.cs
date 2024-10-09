using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _MessageBox {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender , EventArgs e) {

		}

		private void button1_Click(object sender , EventArgs e) {
			//MessageBox.Show("展示的文本内容","弹窗的标题（左上角）","按钮类型","文本内容前的图标","默认选中的按钮","样式","布尔类型（是否有帮助按钮）");
			MessageBox.Show("文本");
			MessageBox.Show("文本","标题");
			MessageBox.Show("文本","标题",MessageBoxButtons.OK);
			MessageBox.Show("文本","标题",MessageBoxButtons.OK,MessageBoxIcon.Error);
			MessageBox.Show("文本","标题",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
			//MessageBox.Show("文本","标题",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
			//MessageBox.Show("文本","标题",MessageBoxButtons.OK,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1,);

			//当按钮被点击运行之后 将具有返回值 返回的是点击的按钮的枚举
			DialogResult x = MessageBox.Show("文本","标题",MessageBoxButtons.YesNoCancel);
			if ( x == DialogResult.Yes ) {
				MessageBox.Show("你点击的是YES");
			} else {
				MessageBox.Show("你点击的是NO");
			}
		}
	}
}
