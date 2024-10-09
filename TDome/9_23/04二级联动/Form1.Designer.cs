namespace _04二级联动
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
            this.foodCategory = new System.Windows.Forms.ComboBox();
            this.food = new System.Windows.Forms.ComboBox();
            this.食物类别 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // foodCategory
            // 
            this.foodCategory.FormattingEnabled = true;
            this.foodCategory.Location = new System.Drawing.Point(106, 129);
            this.foodCategory.Name = "foodCategory";
            this.foodCategory.Size = new System.Drawing.Size(121, 20);
            this.foodCategory.TabIndex = 0;
            this.foodCategory.SelectedIndexChanged += new System.EventHandler(this.foodCategory_SelectedIndexChanged);
            // 
            // food
            // 
            this.food.FormattingEnabled = true;
            this.food.Location = new System.Drawing.Point(280, 129);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(121, 20);
            this.food.TabIndex = 1;
            // 
            // 食物类别
            // 
            this.食物类别.AutoSize = true;
            this.食物类别.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.食物类别.Location = new System.Drawing.Point(102, 89);
            this.食物类别.Name = "食物类别";
            this.食物类别.Size = new System.Drawing.Size(89, 20);
            this.食物类别.TabIndex = 2;
            this.食物类别.Text = "食物类别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(276, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "具体的食物";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 246);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.食物类别);
            this.Controls.Add(this.food);
            this.Controls.Add(this.foodCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox foodCategory;
        private System.Windows.Forms.ComboBox food;
        private System.Windows.Forms.Label 食物类别;
        private System.Windows.Forms.Label label2;
    }
}

