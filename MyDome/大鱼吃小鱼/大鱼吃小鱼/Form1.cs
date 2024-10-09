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

namespace 大鱼吃小鱼
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private int Ufw = 100;
        /// <summary>
        /// 游戏是否开始
        /// </summary>
        private bool UserFlag = false;
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
            timer1.Enabled = true;
            for (int i = 0; i < this.Controls.Count;)
            {
                this.Controls.RemoveAt(0);
            }
            this.WindowState = FormWindowState.Maximized;
            PictureBox Userfish = new PictureBox();
            Userfish.Image = Image.FromFile(@"./image/sy.png");
            Userfish.Width = Ufw;
            Userfish.Height = Ufw/2;
            Userfish.SizeMode = PictureBoxSizeMode.StretchImage;
            Userfish.BackColor = Color.Transparent;
            this.Controls.Add(Userfish);
            UserFlag = true;
        }
        private int DirecTion = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (UserFlag)
            { 
            PictureBox Userfish = (PictureBox)this.Controls[0];
                int X = e.X > this.Width - Userfish.Width ? this.Width - (Userfish.Width + 20):e.X;
                int Y = e.Y > this.Height - Userfish.Height ? this.Height - Userfish.Height*2 : e.Y;
				DirecTion = e.X;

				if ( e.X > DirecTion) Userfish.Image = Image.FromFile(@"./image/sy.png");
                else Userfish.Image = Image.FromFile(@"./image/sy2.png");
                Userfish.Location=new Point(X, Y);

            }
        }

		private Random ra = new Random();
        string[] SrcArr = Directory.GetFiles(@"./image", "*.png");
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (UserFlag)
            {
                int SmallX = 0;
                timer1.Interval = ra.Next(1,10) * 1000;
                for(int i = 0; i < ra.Next(5); i++)
                {
                    PictureBox UserFish = new PictureBox();
                    string FX = SrcArr[ra.Next(3, 11)];
                    UserFish.Width = ra.Next(300);
                    UserFish.Height = UserFish.Width / 2;
                    
                    if (Convert.ToInt32(FX.Split('.')[1].Split('y')[1].Length) > 1)
                    {
                        SmallX = 0;
                        UserFish.Name = "Right";

                    }
                    else
                    {
                        SmallX = this.Width;
                        UserFish.Name = "Left";
                    }
                    UserFish.Image =Image.FromFile(FX);
                    UserFish.Location = new Point(SmallX, ra.Next(this.Height - UserFish.Height));
                    UserFish.SizeMode = PictureBoxSizeMode.StretchImage;
                    UserFish.BackColor = Color.Transparent;
                    //UserFish.MouseMove += USerMOve;
                    this.Controls.Add(UserFish);
                }
                }
            }
        private void USerMOve(object sender, MouseEventArgs e)
        {
            PictureBox UserF = (PictureBox)this.Controls[0];
            PictureBox S = (PictureBox)sender;
            UserF.Location = new Point(e.X + S.Location.X, e.Y + S.Location.Y);
        }

        //🐟移动
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (UserFlag)
            {
                PictureBox UserF = (PictureBox)this.Controls[0];

                for (int i = 1; i < this.Controls.Count; i++)
                {
                    PictureBox P = (PictureBox)this.Controls[i];
                    int X = P.Location.X;
                    if (P.Name == "Right")
                    {
                        X += 10;
                     
                        if (X + P.Width > UserF.Location.X && X + P.Width < UserF.Location.X + UserF.Width)
                        {
                            if (P.Location.Y + P.Height > UserF.Location.Y && P.Location.Y < UserF.Location.Y + UserF.Height)
                            {
                                if (UserF.Width > P.Width && UserF.Height > P.Height)
                                {
                                    this.Controls.Remove(P);
                                    UserF.Width += 21;
                                    UserF.Height += 7;

                                }
                                else
                                {
                                    Form2 F = new Form2(this);
                                    F.Show();
                                    this.Controls.Remove(UserF);
                                    timer2.Enabled = false;
                                    timer1.Enabled = false;
                                    return;
                                }

                            }
                        }
                        //超出边界
                        if (X > this.Width + P.Width) this.Controls.Remove(P);
                    }
                    else
                    {
                        X -= 10;
                        //头进入
                        if (X > UserF.Location.X && X < UserF.Location.X + UserF.Width)
                        {

                            if (P.Location.Y + P.Height > UserF.Location.Y && P.Location.Y < UserF.Location.Y + UserF.Height)
                            {
                                if (UserF.Width > P.Width && UserF.Height > P.Height)
                                {
                                    this.Controls.Remove(P);
                                    UserF.Width += 21;
                                    UserF.Height += 7;
                                }
                                else
                                {
                                    Form2 F = new Form2(this);
                                    F.Show();
                                    this.Controls.Remove(UserF);
									timer2.Enabled = false;
                                    timer1.Enabled = false;
                                    return;
                                }


                            }
                        }
                        //超出边界
                        if (X < -P.Width) this.Controls.Remove(P);
                    }
                    P.Location = new Point(X, P.Location.Y);
                }
            }
        }
    }
}

