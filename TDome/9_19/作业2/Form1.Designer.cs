namespace 作业2
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
            this.components = new System.ComponentModel.Container();
            this.myImage = new System.Windows.Forms.PictureBox();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.myImage)).BeginInit();
            this.SuspendLayout();
            // 
            // myImage
            // 
            this.myImage.Location = new System.Drawing.Point(190, 54);
            this.myImage.Name = "myImage";
            this.myImage.Size = new System.Drawing.Size(428, 309);
            this.myImage.TabIndex = 0;
            this.myImage.TabStop = false;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("宋体", 12F);
            this.next.Location = new System.Drawing.Point(658, 197);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(93, 63);
            this.next.TabIndex = 1;
            this.next.Text = "下一张";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // previous
            // 
            this.previous.Font = new System.Drawing.Font("宋体", 12F);
            this.previous.Location = new System.Drawing.Point(25, 197);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(93, 63);
            this.previous.TabIndex = 2;
            this.previous.Text = "上一张";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.next);
            this.Controls.Add(this.myImage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox myImage;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Timer timer1;
    }
}

