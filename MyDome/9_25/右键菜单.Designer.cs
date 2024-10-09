namespace _9_25 {
	partial class 右键菜单 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if ( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.黏贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.关机ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.重启ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.窗体加载时ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.挂载的右键菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.contextMenuStrip2.SuspendLayout();
			this.contextMenuStrip3.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制ToolStripMenuItem,
            this.黏贴ToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
			// 
			// 复制ToolStripMenuItem
			// 
			this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
			this.复制ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.复制ToolStripMenuItem.Text = "复制";
			this.复制ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// 黏贴ToolStripMenuItem
			// 
			this.黏贴ToolStripMenuItem.Name = "黏贴ToolStripMenuItem";
			this.黏贴ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.黏贴ToolStripMenuItem.Text = "粘贴";
			this.黏贴ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// contextMenuStrip2
			// 
			this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关机ToolStripMenuItem,
            this.重启ToolStripMenuItem});
			this.contextMenuStrip2.Name = "contextMenuStrip2";
			this.contextMenuStrip2.Size = new System.Drawing.Size(101, 48);
			// 
			// 关机ToolStripMenuItem
			// 
			this.关机ToolStripMenuItem.Name = "关机ToolStripMenuItem";
			this.关机ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.关机ToolStripMenuItem.Text = "关机";
			this.关机ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// 重启ToolStripMenuItem
			// 
			this.重启ToolStripMenuItem.Name = "重启ToolStripMenuItem";
			this.重启ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
			this.重启ToolStripMenuItem.Text = "重启";
			this.重启ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(59, 57);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 87);
			this.button1.TabIndex = 2;
			this.button1.Text = "使用复制粘贴";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(328, 57);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(132, 87);
			this.button2.TabIndex = 3;
			this.button2.Text = "使用关机重启";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// contextMenuStrip3
			// 
			this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.窗体加载时ToolStripMenuItem,
            this.挂载的右键菜单ToolStripMenuItem});
			this.contextMenuStrip3.Name = "contextMenuStrip3";
			this.contextMenuStrip3.Size = new System.Drawing.Size(161, 48);
			// 
			// 窗体加载时ToolStripMenuItem
			// 
			this.窗体加载时ToolStripMenuItem.Name = "窗体加载时ToolStripMenuItem";
			this.窗体加载时ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.窗体加载时ToolStripMenuItem.Text = "窗体加载时";
			this.窗体加载时ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// 挂载的右键菜单ToolStripMenuItem
			// 
			this.挂载的右键菜单ToolStripMenuItem.Name = "挂载的右键菜单ToolStripMenuItem";
			this.挂载的右键菜单ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
			this.挂载的右键菜单ToolStripMenuItem.Text = "挂载的右键菜单";
			this.挂载的右键菜单ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Name = "Form3";
			this.Text = "Form3";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.contextMenuStrip2.ResumeLayout(false);
			this.contextMenuStrip3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 黏贴ToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
		private System.Windows.Forms.ToolStripMenuItem 关机ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 重启ToolStripMenuItem;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
		private System.Windows.Forms.ToolStripMenuItem 窗体加载时ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 挂载的右键菜单ToolStripMenuItem;
	}
}