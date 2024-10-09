namespace Tag {
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
			this.open = new System.Windows.Forms.Button();
			this.off = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// open
			// 
			this.open.Location = new System.Drawing.Point(174, 300);
			this.open.Name = "open";
			this.open.Size = new System.Drawing.Size(114, 91);
			this.open.TabIndex = 0;
			this.open.Text = "Open";
			this.open.UseVisualStyleBackColor = true;
			this.open.Click += new System.EventHandler(this.open_ClickORoff_Click);
			// 
			// off
			// 
			this.off.Location = new System.Drawing.Point(384, 300);
			this.off.Name = "off";
			this.off.Size = new System.Drawing.Size(138, 91);
			this.off.TabIndex = 1;
			this.off.Text = "Off";
			this.off.UseVisualStyleBackColor = true;
			this.off.Click += new System.EventHandler(this.open_ClickORoff_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Tag.Properties.Resources.宝箱1;
			this.pictureBox1.Location = new System.Drawing.Point(49, 62);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 133);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "false";
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::Tag.Properties.Resources.宝箱1;
			this.pictureBox2.Location = new System.Drawing.Point(278, 62);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(171, 133);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "false";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::Tag.Properties.Resources.宝箱1;
			this.pictureBox3.Location = new System.Drawing.Point(502, 62);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(171, 133);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox3.TabIndex = 4;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Tag = "false";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.off);
			this.Controls.Add(this.open);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button open;
		private System.Windows.Forms.Button off;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
	}
}

