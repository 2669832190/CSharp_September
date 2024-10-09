namespace _9_23作业 {
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
			this.province = new System.Windows.Forms.ComboBox();
			this.city = new System.Windows.Forms.ComboBox();
			this.prefecture = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.Ip = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// province
			// 
			this.province.FormattingEnabled = true;
			this.province.Location = new System.Drawing.Point(171, 296);
			this.province.Name = "province";
			this.province.Size = new System.Drawing.Size(121, 23);
			this.province.TabIndex = 0;
			this.province.SelectedIndexChanged += new System.EventHandler(this.province_SelectedIndexChanged);
			// 
			// city
			// 
			this.city.FormattingEnabled = true;
			this.city.Location = new System.Drawing.Point(361, 297);
			this.city.Name = "city";
			this.city.Size = new System.Drawing.Size(121, 23);
			this.city.TabIndex = 1;
			this.city.SelectedIndexChanged += new System.EventHandler(this.city_SelectedIndexChanged);
			// 
			// prefecture
			// 
			this.prefecture.FormattingEnabled = true;
			this.prefecture.Location = new System.Drawing.Point(554, 298);
			this.prefecture.Name = "prefecture";
			this.prefecture.Size = new System.Drawing.Size(121, 23);
			this.prefecture.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 15F);
			this.label1.Location = new System.Drawing.Point(102, 295);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "省：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("宋体", 15F);
			this.label2.Location = new System.Drawing.Point(296, 295);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "市：";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("宋体", 15F);
			this.label3.Location = new System.Drawing.Point(487, 296);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 25);
			this.label3.TabIndex = 5;
			this.label3.Text = "县：";
			// 
			// Ip
			// 
			this.Ip.Location = new System.Drawing.Point(416, 80);
			this.Ip.Name = "Ip";
			this.Ip.Size = new System.Drawing.Size(242, 25);
			this.Ip.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("宋体", 15F);
			this.label4.Location = new System.Drawing.Point(110, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(288, 25);
			this.label4.TabIndex = 7;
			this.label4.Text = "请输入您想要验证的IP：";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
			this.button1.Location = new System.Drawing.Point(176, 134);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(389, 63);
			this.button1.TabIndex = 8;
			this.button1.Text = "点击按钮进行验证";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Ip);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.prefecture);
			this.Controls.Add(this.city);
			this.Controls.Add(this.province);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox province;
		private System.Windows.Forms.ComboBox city;
		private System.Windows.Forms.ComboBox prefecture;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Ip;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
	}
}

