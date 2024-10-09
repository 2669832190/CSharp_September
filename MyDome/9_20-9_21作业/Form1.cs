using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace _9_20_9_21作业 {
	public partial class Form1 : Form {
		

		public Form1() {
			InitializeComponent();
			
		}

		private void Form1_Load(object sender , EventArgs e) {
			Menu.Text = null;
			string[] strings = File.ReadAllLines("./Menu.txt");
			strings = strings.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
			File.WriteAllLines("./Menu.txt" , strings);
			for ( int i = 0; i < strings.Length; i++ ) {
				Menu.Text += "\n" + strings[i];
			}
			
		}

		private void AddMenuBtn_Click(object sender , EventArgs e) {
			string dishes = Menu_Name.Text;
			//这里可以添加是否存在这道菜！（存在继续放下走，不存在则提示！）
			//bool Ishave = Menu.Text.Equals(dishes);
			//if ( Ishave ) {
			//MessageBox.Show("已存在这道菜品不需要添加！" , "提示" , MessageBoxButtons.OK);
			//} else {
			DialogResult IsOK = MessageBox.Show("即将添加"+dishes+"!","提示",MessageBoxButtons.OKCancel);
				if ( IsOK != DialogResult.Cancel ) {
					using ( StreamWriter writer = new StreamWriter("./Menu.txt" , true) ) {
						writer.Write("\n" + dishes);
					}
					MessageBox.Show("已将" + dishes + "添加！" , "提示");
					Form1_Load(sender , e);
				} else {
					Menu_Name.Text = null;
					return;
				}
			//}
			
			
		}

		private void button1_Click(object sender , EventArgs e) {
			string dishes = Remove_Name.Text;
			//这里可以添加是否存在这道菜！（存在继续放下走，不存在则提示！）
			DialogResult IsOK = MessageBox.Show("即将删除" + dishes + "!" , "提示" , MessageBoxButtons.OKCancel);
			if ( IsOK != DialogResult.Cancel ) {
				string[] dishess = File.ReadAllLines("./Menu.txt");
				string[] newArray = new string[dishess.Length - 1];
				int index = 0;
				for ( int i = 0; i < dishess.Length; i++ ) {
					if ( dishess[i] != dishes ) {
						newArray[index] = dishess[i];
						index++;
					}
				}
				dishess = newArray;
				File.WriteAllLines("./Menu.txt" , dishess);
				MessageBox.Show("已将" + dishes + "删除！" , "提示");
				Form1_Load(sender , e);
			} else {
				Remove_Name.Text = null;
				return;
			}
			
		}

		private void button2_Click(object sender , EventArgs e) {
			string[] strings = File.ReadAllLines("./Menu.txt");
			strings = strings.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
			File.WriteAllLines("./Menu.txt" , strings);
			for ( int i = 0; i < strings.Length; i++ ) {
				Menu.Text += "\n" + strings[i];
			}
			Form2 form2 = new Form2();
			this.Hide();
			form2.ShowDialog();
			this.Dispose();
		}
	}
}
