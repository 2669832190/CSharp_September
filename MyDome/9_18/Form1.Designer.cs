namespace _9_18_Winfomestart {
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
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.button1.ForeColor = System.Drawing.SystemColors.Info;
			this.button1.Location = new System.Drawing.Point(43, 33);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(192, 110);
			this.button1.TabIndex = 0;
			this.button1.Text = "点击试运行";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.UseWaitCursor = true;
			this.button1.Click += new System.EventHandler(this.Trial_Run);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(471, 55);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(189, 159);
			this.button3.TabIndex = 2;
			this.button3.Text = "关闭";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(900, 462);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("仿宋", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
	}
}

