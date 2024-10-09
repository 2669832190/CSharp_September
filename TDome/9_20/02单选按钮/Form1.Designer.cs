namespace _02单选按钮
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
            this.man = new System.Windows.Forms.RadioButton();
            this.woman = new System.Windows.Forms.RadioButton();
            this.sing = new System.Windows.Forms.RadioButton();
            this.jump = new System.Windows.Forms.RadioButton();
            this.rap = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // man
            // 
            this.man.AutoSize = true;
            this.man.Checked = true;
            this.man.Location = new System.Drawing.Point(55, 42);
            this.man.Name = "man";
            this.man.Size = new System.Drawing.Size(35, 16);
            this.man.TabIndex = 0;
            this.man.TabStop = true;
            this.man.Text = "男";
            this.man.UseVisualStyleBackColor = true;
            // 
            // woman
            // 
            this.woman.AutoSize = true;
            this.woman.Location = new System.Drawing.Point(111, 42);
            this.woman.Name = "woman";
            this.woman.Size = new System.Drawing.Size(35, 16);
            this.woman.TabIndex = 1;
            this.woman.TabStop = true;
            this.woman.Text = "女";
            this.woman.UseVisualStyleBackColor = true;
            // 
            // sing
            // 
            this.sing.AutoSize = true;
            this.sing.Checked = true;
            this.sing.Location = new System.Drawing.Point(33, 50);
            this.sing.Name = "sing";
            this.sing.Size = new System.Drawing.Size(35, 16);
            this.sing.TabIndex = 2;
            this.sing.TabStop = true;
            this.sing.Text = "唱";
            this.sing.UseVisualStyleBackColor = true;
            // 
            // jump
            // 
            this.jump.AutoSize = true;
            this.jump.Location = new System.Drawing.Point(89, 50);
            this.jump.Name = "jump";
            this.jump.Size = new System.Drawing.Size(35, 16);
            this.jump.TabIndex = 3;
            this.jump.Text = "跳";
            this.jump.UseVisualStyleBackColor = true;
            // 
            // rap
            // 
            this.rap.AutoSize = true;
            this.rap.Location = new System.Drawing.Point(141, 50);
            this.rap.Name = "rap";
            this.rap.Size = new System.Drawing.Size(41, 16);
            this.rap.TabIndex = 4;
            this.rap.TabStop = true;
            this.rap.Text = "rap";
            this.rap.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.woman);
            this.panel1.Controls.Add(this.man);
            this.panel1.Location = new System.Drawing.Point(31, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rap);
            this.panel2.Controls.Add(this.sing);
            this.panel2.Controls.Add(this.jump);
            this.panel2.Location = new System.Drawing.Point(31, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 50);
            this.button1.TabIndex = 9;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton man;
        private System.Windows.Forms.RadioButton woman;
        private System.Windows.Forms.RadioButton sing;
        private System.Windows.Forms.RadioButton jump;
        private System.Windows.Forms.RadioButton rap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
    }
}

