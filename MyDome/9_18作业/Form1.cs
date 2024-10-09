using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_18作业 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}
		#region T1,T2

		/// <summary>
		/// 用户名长度最小值
		/// </summary>
		int usernameminL = 3;
		/// <summary>
		/// 用户名长度最大值
		/// </summary>
		int usernamemaxL = 6;
		/// <summary>
		/// 密码长度最小值
		/// </summary>
		int passwordminL = 6;
		/// <summary>
		/// 密码长度最大值
		/// </summary>
		int passwordmaxL = 12;
		/// <summary>
		/// 用户名格式判断
		/// </summary>
		private void UserName(object sender , EventArgs e) {
			string un = username.Text;
			try {
				if ( ( (char)un[0] >= 'A' && (char)un[0] <= 'Z' ) || ( (char)un[0] >= 'a' && (char)un[0] <= 'z' ) ) {
					username_gth.Visible = false;
					if ( un.Length >= usernameminL && un.Length <= usernamemaxL ) {
						username_gth.Visible = false;
						for ( int i = 0; i < un.Length; i++ ) {
							foreach ( char c in un ) {
								if ( ( c >= 'A' && c <= 'Z' ) || ( c >= 'a' && c <= 'z' ) || ( c >= '0' && c <= '9' ) || c == '_' ) {
									username_gth.Visible = false;
								} else {
									username_gth.Visible = true;
								}
							}
						}
					} else {
						username_gth.Visible = true;
					}
				} else {
					username_gth.Visible = true;
				}
			} catch ( Exception ) {
			}
		}
		/// <summary>
		/// 密码格式判断
		/// </summary>
		private void PassWord(object sender , EventArgs e) {
			string un = password.Text;
			try {
				if ( ( (char)un[0] >= 'A' && (char)un[0] <= 'Z' ) || ( (char)un[0] >= 'a' && (char)un[0] <= 'z' ) ) {
					password_gth.Visible = false;
					if ( un.Length >= passwordminL && un.Length <= passwordmaxL ) {
						password_gth.Visible = false;
						for ( int i = 0; i < un.Length; i++ ) {
							foreach ( char c in un ) {
								if ( ( c >= 'A' && c <= 'Z' ) || ( c >= 'a' && c <= 'z' ) || ( c >= '0' && c <= '9' ) || c == '_' ) {
									password_gth.Visible = false;
								} else {
									password_gth.Visible = true;
								}
							}
						}
					} else {
						password_gth.Visible = true;
					}
				} else {
					password_gth.Visible = true;
				}
			} catch ( Exception ) {
			}
		}
		/// <summary>
		/// 用户名：鼠标从感叹号移入时
		/// </summary>
		private void UserNameTS(object sender , EventArgs e) {
			usernameTS.Visible = true;
		}
		/// <summary>
		/// 用户名：鼠标从感叹号移出时
		/// </summary>
		private void UserNameTs(object sender , EventArgs e) {
			usernameTS.Visible = false;
		}
		/// <summary>
		/// 密码：鼠标从感叹号移入时
		/// </summary>
		private void PassWordTS(object sender , EventArgs e) {
			passwprdTS.Visible = true;
		}

		/// <summary>
		/// 密码：鼠标从感叹号移出时
		/// </summary>
		private void PassWordTs(object sender , EventArgs e) {
			passwprdTS.Visible = false;
		}

		/// <summary>
		/// 存储用户名及密码
		/// </summary>
		Dictionary<string,string> keyValues = new Dictionary<string,string>();
		/// <summary>
		/// 登录判断
		/// </summary>
		private void button1_Click(object sender , EventArgs e) {
			string USERNAME = username.Text;
			string PASSWORD = password.Text;
			if ( keyValues[USERNAME] == PASSWORD ) {
				MessageBox.Show("登录成功！");
			} else {
				MessageBox.Show("登录失败！\n用户名或密码！\n错误请重试!");
			}
		}
		/// <summary>
		/// 注册存入字典
		/// </summary>
		private void button3_Click(object sender , EventArgs e) {
			string USERNAME = username.Text;
			string PASSWORD = password.Text;
			if ( username_gth.Visible == true && password_gth.Visible == true ) {
				if ( keyValues.ContainsKey(USERNAME) ) {
					MessageBox.Show("已存在用户名无法进行注册！");
				} else {
					keyValues.Add(USERNAME , PASSWORD);
					MessageBox.Show("注册成功！\n请进行登录！");
				}
			} else {
				MessageBox.Show("请输入合法的用户名及密码！");
			}
		}
		#endregion

		#region T3,T4

		/// <summary>
		/// 图片的相对路径
		/// </summary>
		string[] imgagespath = new string[] {
			"images\\1.jpg",
			"images\\2.jpg",
			"images\\3.jpg"
		};
		/// <summary>
		/// 图片索引
		/// </summary>
		int index = 0;

		/// <summary>
		/// 初始化
		/// </summary>
		private void Form1_Load(object sender , EventArgs e) {
			Image image = Image.FromFile(imgagespath[index]);
			imgbox.Image = image;
			Index();
		}

		#region 上下一张逻辑
		/// <summary>
		/// 下一张
		/// </summary>
		private void rightBut_Click(object sender , EventArgs e) {
			rightbut_imgbox_Carousel();
			imgbox.Image = Image.FromFile(imgagespath[index]);
			Index();
		}
		/// <summary>
		/// 上一张
		/// </summary>
		private void leftBut_Click(object sender , EventArgs e) {
			leftbut_imgbox_Carousel();
			imgbox.Image = Image.FromFile(imgagespath[index]);
			Index();

		}
		void rightbut_imgbox_Carousel() {
			if ( index == imgagespath.Length - 1 ) {
				index = 0;
			} else {
				index++;
			}
		}
		void leftbut_imgbox_Carousel() {
			if ( index == 0 ) {
				index = imgagespath.Length - 1;
			} else {
				index--;
			}
		}
		#endregion

		#region 图片下方实心圆的变化
		private void label1_Click(object sender , EventArgs e) {
			index = 0;
			imgbox.Image = Image.FromFile(imgagespath[index]);
			Index();

		}
		private void label2_Click(object sender , EventArgs e) {
			index = 1;
			imgbox.Image = Image.FromFile(imgagespath[index]);
			Index();

		}
		private void label3_Click(object sender , EventArgs e) {
			index = 2;
			imgbox.Image = Image.FromFile(imgagespath[index]);
			Index();
		}

		void Index() {
			switch ( index ) {
				case 0:
					label1.ForeColor = Color.Red;
					label2.ForeColor = Color.Black;
					label3.ForeColor = Color.Black;
					break;
				case 1:
					label2.ForeColor = Color.Red;
					label1.ForeColor = Color.Black;
					label3.ForeColor = Color.Black;

					break;
				case 2:
					label3.ForeColor = Color.Red;
					label1.ForeColor = Color.Black;
					label2.ForeColor = Color.Black;

					break;
				default:
					break;
			}
		}
		#endregion

		#region 定时器
		private void timer_img(object sender , EventArgs e) {
			if ( index != imgagespath.Length - 1 ) {
				index++;
			} else {
				index = 0;
			}
			imgbox.Image = Image.FromFile(imgagespath[index]);
			Index();
		}

		#endregion

		#endregion

	}
}
