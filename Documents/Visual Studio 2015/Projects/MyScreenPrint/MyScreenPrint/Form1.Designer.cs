namespace MyScreenPrint
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
            this.screenPic = new System.Windows.Forms.PictureBox();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.printScrBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screenPic)).BeginInit();
            this.operationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenPic
            // 
            this.screenPic.BackColor = System.Drawing.Color.Black;
            this.screenPic.Location = new System.Drawing.Point(21, 12);
            this.screenPic.Name = "screenPic";
            this.screenPic.Size = new System.Drawing.Size(1045, 606);
            this.screenPic.TabIndex = 0;
            this.screenPic.TabStop = false;
            // 
            // operationPanel
            // 
            this.operationPanel.Controls.Add(this.printScrBtn);
            this.operationPanel.Location = new System.Drawing.Point(1072, 12);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(109, 606);
            this.operationPanel.TabIndex = 1;
            // 
            // printScrBtn
            // 
            this.printScrBtn.Location = new System.Drawing.Point(4, 4);
            this.printScrBtn.Name = "printScrBtn";
            this.printScrBtn.Size = new System.Drawing.Size(102, 48);
            this.printScrBtn.TabIndex = 0;
            this.printScrBtn.Text = "Print Screen";
            this.printScrBtn.UseVisualStyleBackColor = true;
            this.printScrBtn.Click += new System.EventHandler(this.printScrBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 630);
            this.Controls.Add(this.operationPanel);
            this.Controls.Add(this.screenPic);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.screenPic)).EndInit();
            this.operationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screenPic;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Button printScrBtn;
    }
}

