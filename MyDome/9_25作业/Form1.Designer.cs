namespace _9_25作业 {
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
			this.RightMenuOne = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.打开Json文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.FileContent = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.RightMenuOne.SuspendLayout();
			this.SuspendLayout();
			// 
			// RightMenuOne
			// 
			this.RightMenuOne.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开Json文件ToolStripMenuItem,
            this.toolStripMenuItem2});
			this.RightMenuOne.Name = "RightMenuOne";
			this.RightMenuOne.Size = new System.Drawing.Size(151, 48);
			// 
			// 打开Json文件ToolStripMenuItem
			// 
			this.打开Json文件ToolStripMenuItem.Name = "打开Json文件ToolStripMenuItem";
			this.打开Json文件ToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
			this.打开Json文件ToolStripMenuItem.Text = "打开Json文件";
			this.打开Json文件ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 22);
			this.toolStripMenuItem2.Text = "！！！";
			// 
			// FileContent
			// 
			this.FileContent.AutoSize = true;
			this.FileContent.Font = new System.Drawing.Font("宋体", 30F);
			this.FileContent.Location = new System.Drawing.Point(63, 159);
			this.FileContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.FileContent.Name = "FileContent";
			this.FileContent.Size = new System.Drawing.Size(0, 40);
			this.FileContent.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("宋体", 30F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(204, 46);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(511, 40);
			this.label1.TabIndex = 2;
			this.label1.Text = "点击鼠标右键选择Json文件";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 562);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FileContent);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.RightMenuOne.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip RightMenuOne;
		private System.Windows.Forms.ToolStripMenuItem 打开Json文件ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.Label FileContent;
		private System.Windows.Forms.Label label1;
	}
}

