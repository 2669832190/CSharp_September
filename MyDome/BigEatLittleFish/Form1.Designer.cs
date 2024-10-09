namespace BigEatLittleFish {
	partial class BigEatLittleF {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigEatLittleF));
			this.begin = new System.Windows.Forms.PictureBox();
			this.AddFishTime = new System.Windows.Forms.Timer(this.components);
			this.MoveFishTime = new System.Windows.Forms.Timer(this.components);
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.begin)).BeginInit();
			this.SuspendLayout();
			// 
			// begin
			// 
			this.begin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.begin.BackColor = System.Drawing.Color.Transparent;
			this.begin.BackgroundImage = global::BigEatLittleFish.Properties.Resources.startGameBtn;
			this.begin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.begin.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.begin.Location = new System.Drawing.Point(319, 259);
			this.begin.Name = "begin";
			this.begin.Size = new System.Drawing.Size(100, 50);
			this.begin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.begin.TabIndex = 0;
			this.begin.TabStop = false;
			this.begin.Click += new System.EventHandler(this.begin_Click);
			// 
			// AddFishTime
			// 
			this.AddFishTime.Interval = 1000;
			this.AddFishTime.Tick += new System.EventHandler(this.AddFishTime_Tick);
			// 
			// MoveFishTime
			// 
			this.MoveFishTime.Enabled = true;
			this.MoveFishTime.Tick += new System.EventHandler(this.MoveFishTime_Tick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("宋体", 50F);
			this.label1.ForeColor = System.Drawing.Color.LightCoral;
			this.label1.Location = new System.Drawing.Point(220, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(364, 67);
			this.label1.TabIndex = 1;
			this.label1.Text = "大鱼吃小鱼";
			// 
			// BigEatLittleF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::BigEatLittleFish.Properties.Resources.bg;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.begin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "BigEatLittleF";
			this.Text = "Big fish eat little fish";
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BigEatLittleF_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.begin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox begin;
		private System.Windows.Forms.Timer AddFishTime;
		private System.Windows.Forms.Timer MoveFishTime;
		private System.Windows.Forms.Label label1;
	}
}

