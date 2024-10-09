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

namespace _9_20_9_21作业 {
	public partial class Form2 : Form {
		CheckedListBox Menu = new CheckedListBox();
		CheckedListBox Selecteddishes = new CheckedListBox();
		bool Istrue = false;
		public Form2() {
			InitializeComponent();
			MenuList();
			AddRestoreBtn();
			AddBtn();
			AddCancelBtn();
		}

		//初始状态
		private void MenuList() {
			//待选区
			Menu.Name = "WaitingArea";
			Menu.Location = new Point(200 , 50);
			Menu.Size = new Size(130 , 212);
			this.Controls.Add(Menu);
			//已选区
			Selecteddishes.Name = "SelectedArea";
			Selecteddishes.Location = new Point(450 , 50);
			Selecteddishes.Size = new Size(130 , 212);
			this.Controls.Add(Selecteddishes);
			//向待选区加入菜品
			string[] menus = File.ReadAllLines("./Menu.txt");
            foreach (string item in menus)
            {
	            Menu.Items.Add(item);
			}
		}


		/// <summary>
		/// 还原按钮生成
		/// </summary>
		private void AddRestoreBtn() { 
			Button Restore = new Button();
			Restore.Name = "restore";
			Restore.Text = "还原";
			Restore.Size = new Size(100,50);
			//wite
			Restore.Location = new Point(339 , 326);
			Restore.Click += Restore_Click;
			this.Controls.Add(Restore);
		}
		/// <summary>
		/// 还原按钮点击事件
		/// </summary>
		private void Restore_Click(object sender , EventArgs e) {
			//清除现有的所有菜品
			Menu.Items.Clear();
			Selecteddishes.Items.Clear();
			//重新进项添加菜品
			string[] menus = File.ReadAllLines("./Menu.txt");
			foreach ( string item in menus ) {
				Menu.Items.Add(item);
			}
		}



		/// <summary>
		/// 添加菜品按钮生成
		/// </summary>
		private void AddBtn() {
			Button Add  = new Button();
			Add.Name = "add";
			Add.Text = ">";
			Add.Size = new Size(50 , 50);
			//wite
			Add.Location = new Point(363 , 194); 
			Add.Click += Add_Click;
			this.Controls.Add(Add);
		}
		/// <summary>
		/// 添加菜品按钮点击事件
		/// </summary>
		private void Add_Click(object sender , EventArgs e) {
			List<string> list = Menu.CheckedItems.Cast<string>().ToList();
            foreach (string item in list)
            {
				//循环将list里选中的菜品添加到右侧已选区
				Selecteddishes.Items.Add(item);
				//添加完后进行在待选区中删除菜品
				Menu.Items.Remove(item);
            }
        }
		/// <summary>
		/// 取消菜品按钮生成
		/// </summary>
		private void AddCancelBtn() {
			Button Cancel  = new Button();
			Cancel.Name = "cancel";
			Cancel.Text = "<";
			Cancel.Size = new Size(50 , 50);
			//wite
			Cancel.Location = new Point(363 , 62);
			Cancel.Click += Cancel_Click;
			this.Controls.Add(Cancel);
		}
		/// <summary>
		/// 取消菜品按钮点击事件
		/// </summary>
		private void Cancel_Click(object sender , EventArgs e) {
			List<string> list = Selecteddishes.CheckedItems.Cast<string>().ToList();
            foreach (string item in list)
            {
                Menu.Items.Add(item);
				Selecteddishes.Items.Remove(item);
            }
        }




























		//初始状态（还原）
		private void NewMenuList() {
			//左菜单界面
			Menu.Name = "menu";
			Menu.Location = new Point(95 , 25);
			Menu.Size = new Size(130 , 212);
			this.Controls.Add(Menu);
			//右菜单界面
			Selecteddishes.Name = "Selecteddishes";
			Selecteddishes.Location = new Point(360 , 25);
			Selecteddishes.Size = new Size(130 , 212);
			this.Controls.Add(Selecteddishes);
			//给左菜单界面赋值
			List<string> list = new List<string>();
			using ( StreamReader read = new StreamReader("./Menu.txt" , Encoding.UTF8) ) {
				while ( !read.EndOfStream ) {
					list.Add(read.ReadLine());
				}
			}
			foreach ( string s in list ) {
				Menu.Items.Add(s);
			}

			//复制菜单
			File.Copy("./Menu.txt" , "./Menu_processing/leftMenulist.txt" , true);
		}

		private void AddorRomave() {
			if ( Istrue ) {
				// 选中的复制到右侧菜单中
				List<string> list = Menu.CheckedItems.Cast<string>().ToList();
				File.WriteAllLines("./Menu_processing/rightMenulist.txt" , list);

				//右侧的所有项
				//string[] right = list.ToArray();
				foreach ( string item in list ) {
					Selecteddishes.Items.Add(item);
				}
				List<string> dishess = File.ReadAllLines("./Menu_processing/leftMenulist.txt").ToList();
				for ( int i = 0; i < dishess.Count; i++ ) {
					for ( int j = 0; j < Selecteddishes.Items.Count; j++ ) {
						try {
							if ( dishess[i].IndexOf((string)Selecteddishes.Items[j]) == -1 ) {
								dishess.Remove((string)Selecteddishes.Items[j]);
							}
						} catch ( Exception ) {


						}

					}
				}


				Menu.Items.Clear();
				//给菜单集合赋值
				foreach ( string item in dishess ) {
					if ( dishess != null ) {
						Menu.Items.Add(item);
					}
				}
			} else {
				List<string> list = Selecteddishes.CheckedItems.Cast<string>().ToList();
				File.WriteAllLines("./Menu_processing/leftMenulist.txt" , list);
				foreach ( string item in list ) {
					Menu.Items.Add(item);
				}

				List<string> dishess = File.ReadAllLines("./Menu_processing/rightMenulist.txt").ToList();
				for ( int i = 0; i < dishess.Count; i++ ) {
					for ( int j = 0; j < Menu.Items.Count; j++ ) {
						if ( dishess[i].IndexOf((string)Menu.Items[j]) == -1 ) {
							dishess.Remove((string)Menu.Items[j]);
						}
					}
				}
				Selecteddishes.Items.Clear();
				//给菜单集合赋值
				foreach ( string item in dishess ) {
					if ( dishess != null ) {
						Selecteddishes.Items.Add(item);
					}
				}
			}



		}

		private void ADD_Click(object sender , EventArgs e) {
			Istrue = true;
			AddorRomave();
			//File.Create("./Menu_processing/leftMenulist.txt");
			//File.Create("./Menu_processing/rightMenulist.txt");
		}

		private void button3_Click(object sender , EventArgs e) {
			//File.Create("./Menu_processing/leftMenulist.txt");
			//File.Create("./Menu_processing/rightMenulist.txt");
			Menu.Items.Clear();
			Selecteddishes.Items.Clear();
			NewMenuList();
		}

		private void button1_Click(object sender , EventArgs e) {
			Istrue = false;
			AddorRomave();
		}
	}
}
