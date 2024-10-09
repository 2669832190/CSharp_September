namespace _9_18作业 {
	partial class Form1 {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.leftBut = new System.Windows.Forms.Button();
			this.rightBut = new System.Windows.Forms.Button();
			this.imgbox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.label4 = new System.Windows.Forms.Label();
			this.usernameT = new System.Windows.Forms.Label();
			this.passwordT = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.username = new System.Windows.Forms.TextBox();
			this.password = new System.Windows.Forms.TextBox();
			this.username_gth = new System.Windows.Forms.Label();
			this.password_gth = new System.Windows.Forms.Label();
			this.passwprdTS = new System.Windows.Forms.Label();
			this.usernameTS = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgbox)).BeginInit();
			this.SuspendLayout();
			// 
			// leftBut
			// 
			this.leftBut.BackColor = System.Drawing.SystemColors.Control;
			this.leftBut.Location = new System.Drawing.Point(279, 635);
			this.leftBut.Name = "leftBut";
			this.leftBut.Size = new System.Drawing.Size(50, 50);
			this.leftBut.TabIndex = 1;
			this.leftBut.Text = "<";
			this.leftBut.UseVisualStyleBackColor = false;
			this.leftBut.Click += new System.EventHandler(this.leftBut_Click);
			// 
			// rightBut
			// 
			this.rightBut.BackColor = System.Drawing.SystemColors.Control;
			this.rightBut.Location = new System.Drawing.Point(1143, 635);
			this.rightBut.Name = "rightBut";
			this.rightBut.Size = new System.Drawing.Size(50, 50);
			this.rightBut.TabIndex = 2;
			this.rightBut.Text = ">";
			this.rightBut.UseVisualStyleBackColor = false;
			this.rightBut.Click += new System.EventHandler(this.rightBut_Click);
			// 
			// imgbox
			// 
			this.imgbox.BackColor = System.Drawing.SystemColors.Control;
			this.imgbox.Location = new System.Drawing.Point(256, 388);
			this.imgbox.Name = "imgbox";
			this.imgbox.Size = new System.Drawing.Size(960, 504);
			this.imgbox.TabIndex = 0;
			this.imgbox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(682, 849);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "●";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(724, 849);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(22, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "●";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(767, 849);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(22, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "●";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_img);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 30F);
			this.label4.Location = new System.Drawing.Point(535, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(322, 50);
			this.label4.TabIndex = 6;
			this.label4.Text = "登录注册系统";
			// 
			// usernameT
			// 
			this.usernameT.AutoSize = true;
			this.usernameT.Location = new System.Drawing.Point(466, 92);
			this.usernameT.Name = "usernameT";
			this.usernameT.Size = new System.Drawing.Size(67, 15);
			this.usernameT.TabIndex = 7;
			this.usernameT.Text = "用户名：";
			// 
			// passwordT
			// 
			this.passwordT.AutoSize = true;
			this.passwordT.Location = new System.Drawing.Point(469, 133);
			this.passwordT.Name = "passwordT";
			this.passwordT.Size = new System.Drawing.Size(52, 15);
			this.passwordT.TabIndex = 8;
			this.passwordT.Text = "密码：";
			// 
			// button1
			// 
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.Location = new System.Drawing.Point(472, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(145, 66);
			this.button1.TabIndex = 9;
			this.button1.Text = "登录";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button3.Location = new System.Drawing.Point(712, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(145, 66);
			this.button3.TabIndex = 11;
			this.button3.Text = "注册";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// username
			// 
			this.username.Location = new System.Drawing.Point(544, 89);
			this.username.Name = "username";
			this.username.Size = new System.Drawing.Size(313, 25);
			this.username.TabIndex = 12;
			this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.username.TextChanged += new System.EventHandler(this.UserName);
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(544, 130);
			this.password.Name = "password";
			this.password.PasswordChar = '*';
			this.password.Size = new System.Drawing.Size(313, 25);
			this.password.TabIndex = 13;
			this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.password.TextChanged += new System.EventHandler(this.PassWord);
			// 
			// username_gth
			// 
			this.username_gth.AutoSize = true;
			this.username_gth.Font = new System.Drawing.Font("华文中宋", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.username_gth.ForeColor = System.Drawing.Color.Coral;
			this.username_gth.Location = new System.Drawing.Point(880, 81);
			this.username_gth.Name = "username_gth";
			this.username_gth.Size = new System.Drawing.Size(28, 39);
			this.username_gth.TabIndex = 14;
			this.username_gth.Text = "!";
			this.username_gth.Visible = false;
			this.username_gth.MouseEnter += new System.EventHandler(this.UserNameTS);
			this.username_gth.MouseLeave += new System.EventHandler(this.UserNameTs);
			// 
			// password_gth
			// 
			this.password_gth.AutoSize = true;
			this.password_gth.Font = new System.Drawing.Font("华文中宋", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.password_gth.ForeColor = System.Drawing.Color.Coral;
			this.password_gth.Location = new System.Drawing.Point(880, 125);
			this.password_gth.Name = "password_gth";
			this.password_gth.Size = new System.Drawing.Size(28, 39);
			this.password_gth.TabIndex = 15;
			this.password_gth.Text = "!";
			this.password_gth.Visible = false;
			this.password_gth.MouseEnter += new System.EventHandler(this.PassWordTS);
			this.password_gth.MouseLeave += new System.EventHandler(this.PassWordTs);
			// 
			// passwprdTS
			// 
			this.passwprdTS.AutoSize = true;
			this.passwprdTS.Location = new System.Drawing.Point(914, 133);
			this.passwprdTS.Name = "passwprdTS";
			this.passwprdTS.Size = new System.Drawing.Size(415, 15);
			this.passwprdTS.TabIndex = 16;
			this.passwprdTS.Text = "密码必须英文开头只能包含数字，字母，_ 并且长度位6-12位";
			this.passwprdTS.Visible = false;
			// 
			// usernameTS
			// 
			this.usernameTS.AutoSize = true;
			this.usernameTS.Location = new System.Drawing.Point(914, 98);
			this.usernameTS.Name = "usernameTS";
			this.usernameTS.Size = new System.Drawing.Size(452, 15);
			this.usernameTS.TabIndex = 17;
			this.usernameTS.Text = "用户名必须是英文字母开头，只能包含数字，字母，_ 长度为3-6位";
			this.usernameTS.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("宋体", 10F);
			this.label5.Location = new System.Drawing.Point(417, 187);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(569, 17);
			this.label5.TabIndex = 18;
			this.label5.Text = "用户名和密码请按照标准格式输入，如出现错误请查看黄色感叹号的提示！";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1410, 927);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.usernameTS);
			this.Controls.Add(this.passwprdTS);
			this.Controls.Add(this.password_gth);
			this.Controls.Add(this.username_gth);
			this.Controls.Add(this.password);
			this.Controls.Add(this.username);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.passwordT);
			this.Controls.Add(this.usernameT);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rightBut);
			this.Controls.Add(this.leftBut);
			this.Controls.Add(this.imgbox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.imgbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button leftBut;
		private System.Windows.Forms.Button rightBut;
		private System.Windows.Forms.PictureBox imgbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label usernameT;
		private System.Windows.Forms.Label passwordT;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox username;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.Label username_gth;
		private System.Windows.Forms.Label password_gth;
		private System.Windows.Forms.Label passwprdTS;
		private System.Windows.Forms.Label usernameTS;
		private System.Windows.Forms.Label label5;
	}
}

