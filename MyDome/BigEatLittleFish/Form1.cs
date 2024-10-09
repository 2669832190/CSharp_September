using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigEatLittleFish {
	public partial class BigEatLittleF : Form {
		public BigEatLittleF() {
			InitializeComponent();
		}
		/// <summary>
		/// 是否开始游戏
		/// </summary>
		private bool IsGame = false;
		/// <summary>
		/// 鲨鱼的初始X轴位置
		/// </summary>
		private int LastPosition = 0;
		/// <summary>
		/// 随机数
		/// </summary>
		Random random = new Random();
		/// <summary>
		/// 获取所有的图片
		/// </summary>
		string[] paths = Directory.GetFiles(@"./img" , "*.png");
		/// <summary>
		/// 游戏开始按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void begin_Click(object sender , EventArgs e) {
			PictureBox pictureBox = sender as PictureBox;
			this.Controls.Remove(pictureBox);
			this.Controls.Remove(label1);
			this.WindowState = FormWindowState.Maximized;
			PictureBox payimg = new PictureBox();
			payimg.Image = Image.FromFile(@"./img/payimg.jpg");
			payimg.Width = 1315;
			payimg.Height = 1080;
			payimg.Size = new Size(payimg.Width , payimg.Height);
			payimg.Location = new Point(500 , 0);
			this.Controls.Add(payimg);
			MessageBox.Show("请扫码支付1r" , "提示" , MessageBoxButtons.OKCancel);
			if ( DialogResult != DialogResult.Cancel ) {
				//定时器开启
				AddFishTime.Enabled = true;
				MoveFishTime.Enabled = true;
				//清空所有的控件
				for ( int i = 0; i < this.Controls.Count; i++ ) {
					this.Controls.RemoveAt(0);
				}
				PictureBox playerF = new PictureBox();
				playerF.Size = new Size(200 , 100);
				playerF.Image = Image.FromFile(@"./img/sy.png");
				playerF.BackColor = Color.Transparent;
				playerF.SizeMode = PictureBoxSizeMode.StretchImage;
				this.Controls.Add(playerF);
				IsGame = true;
			} else {
				MessageBox.Show("请支付","警告");
			}
		}
		/// <summary>
		/// 每次移动时生成新的鲨鱼
		/// </summary>
		private void BigEatLittleF_MouseMove(object sender , MouseEventArgs e) {
			if ( IsGame ) { 
				PictureBox playerf = this.Controls[0] as PictureBox;
				int x = e.X > this.Width - playerf.Width ? this.Width - (playerf.Width + 18) : e.X;
				int y = e.Y > this.Height - playerf.Height ? this.Height - (playerf.Height + 40) : e.Y;
				playerf.Image = LastPosition > e.X ? Image.FromFile(@"./img/sy2.png") : Image.FromFile(@"./img/sy.png");
				LastPosition = e.X;
				playerf.Location = new Point(x , y);
			}
		}
		/// <summary>
		/// 生成🐟
		/// </summary>
		private void AddFishTime_Tick(object sender , EventArgs e) {
			if ( IsGame ) {

				//每次生成🐟设置其X位置（默认值设置为0）
				int SetX = 0;
				//生成🐟的间隔是时间
				AddFishTime.Interval = random.Next(1,10) * 1000;
				for ( int i = 0; i < random.Next(3); i++ ) { 
					PictureBox fish = new PictureBox();
					//随机生成图案
					string Getpath = paths[random.Next(3,11)];
					//设置🐟的大小
					fish.Width = random.Next(50,300);
					fish.Height = fish.Width / 2;
					//设置方向，为设置位置做准备
					if ( ( Getpath.Split('.')[1].Split('y')[1].Length ) > 1 ) {
						//设置生成🐟的初始X轴位置（从左往右运动的时候左上角x的位置为🐟的宽的相反数）
						SetX = -fish.Width;
						//设置统一运动方向
						fish.Tag = "right";
					} else { 
						//设置生成🐟的初始X轴位置（从右往左运动的时候左上角x的位置为窗体的宽）
						SetX = this.Width;
						//设置统一运动方向
						fish.Tag = "left";
					}

					//设置🐟的各种参数
					fish.Image = Image.FromFile( Getpath );
					fish.Location = new Point(SetX,random.Next(this.Height - fish.Height));
					fish.SizeMode = PictureBoxSizeMode.StretchImage;
					fish.BackColor = Color.Transparent;
					fish.MouseMove += FishMove;

					//添加控件
					this.Controls.Add( fish );
				}

			}
		}
		private void FishMove(object sender , MouseEventArgs e) {
			PictureBox playerF = (PictureBox)this.Controls[0];
			PictureBox S = (PictureBox)sender;
			playerF.Location = new Point(e.X + S.Location.X , e.Y + S.Location.Y);
		}
		private void MoveFishTime_Tick(object sender , EventArgs e) {
			if ( IsGame ) {
				PictureBox playerF = this.Controls[0] as PictureBox;
				for ( int i = 1; i < this.Controls.Count; i++ ) { 
					PictureBox fish = this.Controls[i] as PictureBox;
					//获取🐟的x坐标
					int SetX = fish.Location.X;
					if ( fish.Tag == "right" ) {
						//往右走的🐟
						SetX += 3;
						//玩家吃🐟的过程
						//在计算完🐟需要移动后的位置后进行判断🐟的X轴坐标是否在玩家🐟的宽值内
						//判断 (🐟的X 是否大于 玩家🐟的X坐标) 与 (🐟的X 是否小于等于 玩家🐟的身体的宽的X轴的范围)
						if ( fish.Location.X + fish.Width > playerF.Location.X && fish.Location.X + fish.Width < playerF.Location.X + playerF.Width) {
							//判断Y轴的位置
							if ( fish.Location.Y + fish.Height > playerF.Location.Y && fish.Location.Y < playerF.Location.Y + playerF.Height ) {
								//判断玩家是否可以吃掉
								if ( fish.Width < playerF.Width && fish.Height < playerF.Height ) {
									//移除🐟
									this.Controls.Remove(fish);
									playerF.Width += 40;
									playerF.Height += 20;
								} else {
									//失败！！！
									AddFishTime.Enabled = false;
									MoveFishTime.Enabled = false;
									foreach ( Control item in this.Controls ) {
										this.Controls.Remove(item);
									}
									MessageBox.Show("您被吃掉！");
									this.Close();
								}
							}
						}
						//超出边界移除控件
						if ( SetX > this.Width + fish.Width ) this.Controls.Remove(fish);
					} else {
						//往左走的🐟
						SetX -= 3;
						//玩家吃🐟的过程
						//在计算完🐟需要移动后的位置后进行判断🐟的X轴坐标是否在玩家🐟的宽值内
						//判断 (🐟的X 是否大于 玩家🐟的X坐标) 与 (🐟的X 是否小于等于 玩家🐟的身体的宽的X轴的范围)
						if ( SetX > playerF.Location.X && SetX <= playerF.Width + playerF.Location.X ) {
							//判断Y轴的位置
							if ( fish.Location.Y < playerF.Location.Y + playerF.Height && fish.Location.Y + fish.Height > playerF.Location.Y ) {
								//判断玩家是否可以吃掉
								if ( fish.Width < playerF.Width && fish.Height < playerF.Height ) {
									//移除🐟
									this.Controls.Remove(fish);
									playerF.Width += 40;
									playerF.Height += 20;
								} else {
									//失败！！！
									AddFishTime.Enabled = false;
									MoveFishTime.Enabled = false;
									foreach (Control item in this.Controls) {
										this.Controls.Remove(item);
									}
									MessageBox.Show("您被吃掉！");
									this.Close();
								}
							}
						} 
						//超出边界移除控件
						if ( SetX < -fish.Width ) this.Controls.Remove(fish);
					}
					//如果不吃，则一直进行移动重新设置位置
					fish.Location = new Point( SetX, fish.Location.Y );
				}
			}
		}
	}
}
