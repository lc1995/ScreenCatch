namespace MyRPG
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
            this.fightScene = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fightScene)).BeginInit();
            this.SuspendLayout();
            // 
            // fightScene
            // 
            this.fightScene.BackColor = System.Drawing.Color.DarkCyan;
            this.fightScene.Location = new System.Drawing.Point(0, 0);
            this.fightScene.Name = "fightScene";
            this.fightScene.Size = new System.Drawing.Size(700, 500);
            this.fightScene.TabIndex = 0;
            this.fightScene.TabStop = false;
            this.fightScene.Paint += new System.Windows.Forms.PaintEventHandler(this.fightScene_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.fightScene);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fightScene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fightScene;
    }
}

