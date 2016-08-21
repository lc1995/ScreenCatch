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
            this.components = new System.ComponentModel.Container();
            this.screenPic = new System.Windows.Forms.PictureBox();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.printScrBtn = new System.Windows.Forms.Button();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.saveBtn = new System.Windows.Forms.Button();
            this.splitter_1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.penBtn = new System.Windows.Forms.Button();
            this.textBtn = new System.Windows.Forms.Button();
            this.penPixelLabel = new System.Windows.Forms.Label();
            this.textPixelLabel = new System.Windows.Forms.Label();
            this.penPixelSelect = new System.Windows.Forms.NumericUpDown();
            this.textPixelSelect = new System.Windows.Forms.NumericUpDown();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.screenPic)).BeginInit();
            this.operationPanel.SuspendLayout();
            this.picturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penPixelSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPixelSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // screenPic
            // 
            this.screenPic.BackColor = System.Drawing.Color.Transparent;
            this.screenPic.Location = new System.Drawing.Point(16, 17);
            this.screenPic.Name = "screenPic";
            this.screenPic.Size = new System.Drawing.Size(1020, 586);
            this.screenPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.screenPic.TabIndex = 0;
            this.screenPic.TabStop = false;
            this.screenPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.screenPic_MouseDown);
            this.screenPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.screenPic_MouseMove);
            this.screenPic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.screenPic_MouseUp);
            // 
            // operationPanel
            // 
            this.operationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.operationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.operationPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.operationPanel.Controls.Add(this.colorSelect);
            this.operationPanel.Controls.Add(this.colorLabel);
            this.operationPanel.Controls.Add(this.textPixelSelect);
            this.operationPanel.Controls.Add(this.penPixelSelect);
            this.operationPanel.Controls.Add(this.textPixelLabel);
            this.operationPanel.Controls.Add(this.penPixelLabel);
            this.operationPanel.Controls.Add(this.textBtn);
            this.operationPanel.Controls.Add(this.penBtn);
            this.operationPanel.Controls.Add(this.splitter_1);
            this.operationPanel.Controls.Add(this.saveBtn);
            this.operationPanel.Controls.Add(this.printScrBtn);
            this.operationPanel.Location = new System.Drawing.Point(1072, 12);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(109, 606);
            this.operationPanel.TabIndex = 1;
            // 
            // printScrBtn
            // 
            this.printScrBtn.Location = new System.Drawing.Point(2, 3);
            this.printScrBtn.Name = "printScrBtn";
            this.printScrBtn.Size = new System.Drawing.Size(102, 48);
            this.printScrBtn.TabIndex = 0;
            this.printScrBtn.Text = "Print Screen";
            this.printScrBtn.UseVisualStyleBackColor = true;
            this.printScrBtn.Click += new System.EventHandler(this.printScrBtn_Click);
            // 
            // picturePanel
            // 
            this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePanel.AutoScroll = true;
            this.picturePanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picturePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturePanel.Controls.Add(this.screenPic);
            this.picturePanel.Location = new System.Drawing.Point(13, 12);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Size = new System.Drawing.Size(1053, 606);
            this.picturePanel.TabIndex = 2;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(2, 57);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 48);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save Screen";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splitter_1
            // 
            this.splitter_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter_1.Location = new System.Drawing.Point(4, 112);
            this.splitter_1.Name = "splitter_1";
            this.splitter_1.Size = new System.Drawing.Size(100, 1);
            this.splitter_1.TabIndex = 2;
            // 
            // penBtn
            // 
            this.penBtn.BackColor = System.Drawing.Color.Wheat;
            this.penBtn.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.penBtn.Location = new System.Drawing.Point(2, 116);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(37, 36);
            this.penBtn.TabIndex = 4;
            this.penBtn.Text = "Pen";
            this.penBtn.UseVisualStyleBackColor = false;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // textBtn
            // 
            this.textBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBtn.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBtn.Location = new System.Drawing.Point(67, 116);
            this.textBtn.Name = "textBtn";
            this.textBtn.Size = new System.Drawing.Size(37, 36);
            this.textBtn.TabIndex = 5;
            this.textBtn.Text = "A";
            this.textBtn.UseVisualStyleBackColor = false;
            this.textBtn.Click += new System.EventHandler(this.textBtn_Click);
            // 
            // penPixelLabel
            // 
            this.penPixelLabel.AutoSize = true;
            this.penPixelLabel.Location = new System.Drawing.Point(4, 200);
            this.penPixelLabel.Name = "penPixelLabel";
            this.penPixelLabel.Size = new System.Drawing.Size(53, 12);
            this.penPixelLabel.TabIndex = 6;
            this.penPixelLabel.Text = "画笔像素";
            // 
            // textPixelLabel
            // 
            this.textPixelLabel.AutoSize = true;
            this.textPixelLabel.Location = new System.Drawing.Point(4, 252);
            this.textPixelLabel.Name = "textPixelLabel";
            this.textPixelLabel.Size = new System.Drawing.Size(53, 12);
            this.textPixelLabel.TabIndex = 7;
            this.textPixelLabel.Text = "文字像素";
            // 
            // penPixelSelect
            // 
            this.penPixelSelect.Location = new System.Drawing.Point(3, 216);
            this.penPixelSelect.Name = "penPixelSelect";
            this.penPixelSelect.Size = new System.Drawing.Size(101, 21);
            this.penPixelSelect.TabIndex = 8;
            this.penPixelSelect.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.penPixelSelect.ValueChanged += new System.EventHandler(this.penPixelSelect_ValueChanged);
            // 
            // textPixelSelect
            // 
            this.textPixelSelect.Location = new System.Drawing.Point(2, 267);
            this.textPixelSelect.Name = "textPixelSelect";
            this.textPixelSelect.Size = new System.Drawing.Size(101, 21);
            this.textPixelSelect.TabIndex = 9;
            this.textPixelSelect.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.textPixelSelect.ValueChanged += new System.EventHandler(this.textPixelSelect_ValueChanged);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(4, 322);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(29, 12);
            this.colorLabel.TabIndex = 10;
            this.colorLabel.Text = "颜色";
            // 
            // colorSelect
            // 
            this.colorSelect.BackColor = System.Drawing.Color.White;
            this.colorSelect.Location = new System.Drawing.Point(4, 337);
            this.colorSelect.Name = "colorSelect";
            this.colorSelect.Size = new System.Drawing.Size(37, 36);
            this.colorSelect.TabIndex = 5;
            this.colorSelect.UseVisualStyleBackColor = false;
            this.colorSelect.Click += new System.EventHandler(this.colorSelect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 630);
            this.Controls.Add(this.picturePanel);
            this.Controls.Add(this.operationPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.screenPic)).EndInit();
            this.operationPanel.ResumeLayout(false);
            this.operationPanel.PerformLayout();
            this.picturePanel.ResumeLayout(false);
            this.picturePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penPixelSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textPixelSelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox screenPic;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Button printScrBtn;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button colorSelect;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.NumericUpDown textPixelSelect;
        private System.Windows.Forms.NumericUpDown penPixelSelect;
        private System.Windows.Forms.Label textPixelLabel;
        private System.Windows.Forms.Label penPixelLabel;
        private System.Windows.Forms.Button textBtn;
        private System.Windows.Forms.Button penBtn;
        private System.Windows.Forms.Label splitter_1;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

