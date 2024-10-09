namespace _9_20_9_21作业 {
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.Menu = new System.Windows.Forms.Label();
			this.AddMenu = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Menu_Name = new System.Windows.Forms.TextBox();
			this.AddMenuBtn = new System.Windows.Forms.Button();
			this.RemoveMenu = new System.Windows.Forms.GroupBox();
			this.Remove_Menu = new System.Windows.Forms.Label();
			this.Remove_Name = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button2 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.AddMenu.SuspendLayout();
			this.RemoveMenu.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.Menu);
			this.groupBox1.Font = new System.Drawing.Font("宋体", 15F);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(303, 1068);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "菜单展示";
			// 
			// Menu
			// 
			this.Menu.AutoEllipsis = true;
			this.Menu.AutoSize = true;
			this.Menu.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Menu.Location = new System.Drawing.Point(10, 33);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(120, 34);
			this.Menu.TabIndex = 0;
			this.Menu.Text = "菜单：";
			// 
			// AddMenu
			// 
			this.AddMenu.Controls.Add(this.AddMenuBtn);
			this.AddMenu.Controls.Add(this.Menu_Name);
			this.AddMenu.Controls.Add(this.label1);
			this.AddMenu.Font = new System.Drawing.Font("宋体", 15F);
			this.AddMenu.Location = new System.Drawing.Point(336, 12);
			this.AddMenu.Name = "AddMenu";
			this.AddMenu.Size = new System.Drawing.Size(664, 518);
			this.AddMenu.TabIndex = 1;
			this.AddMenu.TabStop = false;
			this.AddMenu.Text = "添加菜品";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 20F);
			this.label1.Location = new System.Drawing.Point(50, 163);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(287, 34);
			this.label1.TabIndex = 0;
			this.label1.Text = "添加的菜品名称：";
			// 
			// Menu_Name
			// 
			this.Menu_Name.Font = new System.Drawing.Font("宋体", 20F);
			this.Menu_Name.Location = new System.Drawing.Point(330, 157);
			this.Menu_Name.Name = "Menu_Name";
			this.Menu_Name.Size = new System.Drawing.Size(269, 46);
			this.Menu_Name.TabIndex = 1;
			// 
			// AddMenuBtn
			// 
			this.AddMenuBtn.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
			this.AddMenuBtn.Location = new System.Drawing.Point(178, 298);
			this.AddMenuBtn.Name = "AddMenuBtn";
			this.AddMenuBtn.Size = new System.Drawing.Size(270, 80);
			this.AddMenuBtn.TabIndex = 2;
			this.AddMenuBtn.Text = "添加菜品";
			this.AddMenuBtn.UseVisualStyleBackColor = true;
			this.AddMenuBtn.Click += new System.EventHandler(this.AddMenuBtn_Click);
			// 
			// RemoveMenu
			// 
			this.RemoveMenu.Controls.Add(this.button1);
			this.RemoveMenu.Controls.Add(this.Remove_Name);
			this.RemoveMenu.Controls.Add(this.Remove_Menu);
			this.RemoveMenu.Font = new System.Drawing.Font("宋体", 15F);
			this.RemoveMenu.Location = new System.Drawing.Point(336, 537);
			this.RemoveMenu.Name = "RemoveMenu";
			this.RemoveMenu.Size = new System.Drawing.Size(664, 543);
			this.RemoveMenu.TabIndex = 2;
			this.RemoveMenu.TabStop = false;
			this.RemoveMenu.Text = "删除菜品";
			// 
			// Remove_Menu
			// 
			this.Remove_Menu.AutoSize = true;
			this.Remove_Menu.Font = new System.Drawing.Font("宋体", 20F);
			this.Remove_Menu.Location = new System.Drawing.Point(72, 200);
			this.Remove_Menu.Name = "Remove_Menu";
			this.Remove_Menu.Size = new System.Drawing.Size(253, 34);
			this.Remove_Menu.TabIndex = 0;
			this.Remove_Menu.Text = "删除的菜品名：";
			// 
			// Remove_Name
			// 
			this.Remove_Name.Font = new System.Drawing.Font("宋体", 20F);
			this.Remove_Name.Location = new System.Drawing.Point(330, 195);
			this.Remove_Name.Name = "Remove_Name";
			this.Remove_Name.Size = new System.Drawing.Size(269, 46);
			this.Remove_Name.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(178, 352);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(270, 80);
			this.button1.TabIndex = 2;
			this.button1.Text = "删除菜品";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button2);
			this.groupBox2.Font = new System.Drawing.Font("宋体", 15F);
			this.groupBox2.Location = new System.Drawing.Point(1019, 13);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(965, 1067);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "点菜系统";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("幼圆", 30F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
			this.button2.Location = new System.Drawing.Point(154, 449);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(585, 172);
			this.button2.TabIndex = 0;
			this.button2.Text = "点击运行点菜系统";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1996, 1092);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.RemoveMenu);
			this.Controls.Add(this.AddMenu);
			this.Controls.Add(this.groupBox1);
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Form1";
			this.Text = "9_20-9_21作业";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.AddMenu.ResumeLayout(false);
			this.AddMenu.PerformLayout();
			this.RemoveMenu.ResumeLayout(false);
			this.RemoveMenu.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label Menu;
		private System.Windows.Forms.GroupBox AddMenu;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddMenuBtn;
		private System.Windows.Forms.TextBox Menu_Name;
		private System.Windows.Forms.GroupBox RemoveMenu;
		private System.Windows.Forms.Label Remove_Menu;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox Remove_Name;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button2;
	}
}

