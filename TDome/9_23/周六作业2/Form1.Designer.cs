namespace 周六作业2
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.notSelectMenu = new System.Windows.Forms.CheckedListBox();
            this.SelectMenu = new System.Windows.Forms.CheckedListBox();
            this.addDish = new System.Windows.Forms.Button();
            this.delDish = new System.Windows.Forms.Button();
            this.reInit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // notSelectMenu
            // 
            this.notSelectMenu.FormattingEnabled = true;
            this.notSelectMenu.Location = new System.Drawing.Point(24, 12);
            this.notSelectMenu.Name = "notSelectMenu";
            this.notSelectMenu.Size = new System.Drawing.Size(155, 340);
            this.notSelectMenu.TabIndex = 0;
            // 
            // SelectMenu
            // 
            this.SelectMenu.FormattingEnabled = true;
            this.SelectMenu.Location = new System.Drawing.Point(362, 12);
            this.SelectMenu.Name = "SelectMenu";
            this.SelectMenu.Size = new System.Drawing.Size(165, 340);
            this.SelectMenu.TabIndex = 1;
            // 
            // addDish
            // 
            this.addDish.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addDish.Location = new System.Drawing.Point(244, 62);
            this.addDish.Name = "addDish";
            this.addDish.Size = new System.Drawing.Size(65, 65);
            this.addDish.TabIndex = 2;
            this.addDish.Text = ">";
            this.addDish.UseVisualStyleBackColor = true;
            this.addDish.Click += new System.EventHandler(this.addDish_Click);
            // 
            // delDish
            // 
            this.delDish.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delDish.Location = new System.Drawing.Point(244, 153);
            this.delDish.Name = "delDish";
            this.delDish.Size = new System.Drawing.Size(65, 65);
            this.delDish.TabIndex = 3;
            this.delDish.Text = "<";
            this.delDish.UseVisualStyleBackColor = true;
            this.delDish.Click += new System.EventHandler(this.delDish_Click);
            // 
            // reInit
            // 
            this.reInit.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.reInit.Location = new System.Drawing.Point(244, 256);
            this.reInit.Name = "reInit";
            this.reInit.Size = new System.Drawing.Size(65, 65);
            this.reInit.TabIndex = 4;
            this.reInit.Text = "还原";
            this.reInit.UseVisualStyleBackColor = true;
            this.reInit.Click += new System.EventHandler(this.reInit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 374);
            this.Controls.Add(this.reInit);
            this.Controls.Add(this.delDish);
            this.Controls.Add(this.addDish);
            this.Controls.Add(this.SelectMenu);
            this.Controls.Add(this.notSelectMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox notSelectMenu;
        private System.Windows.Forms.CheckedListBox SelectMenu;
        private System.Windows.Forms.Button addDish;
        private System.Windows.Forms.Button delDish;
        private System.Windows.Forms.Button reInit;
    }
}

