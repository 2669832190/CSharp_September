using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 多选框 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void button1_Click(object sender , EventArgs e) {
			//hobby.Items.Add("篮球");
			//MessageBox.Show("里面有"+hobby.Items.Count+"项");

			//遍历选中的项
			//foreach (string str in hobby.CheckedItems) { 
			//	MessageBox.Show(str);
			//}


			//当前选定项(鼠标点击方框后的文字即为选中！)
			//MessageBox.Show(hobby.SelectedItem + "");
			//当前选定项的索引
			//MessageBox.Show(hobby.SelectedIndex + "");

			//通过索引获得集合里的内容
			//MessageBox.Show(hobby.Items[0]+"");
			//通过选中项的索引获得的选中项的内容（选中项的索引是将所有选中项放到另一个集合里的索引！！！）
			MessageBox.Show(hobby.CheckedItems[1] +"");
		}
	}
}
