using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MyScreenPrint
{
    public partial class Form1 : Form
    {
        // 截图窗口
        Cutter cutter = null;

        // 截得的图片
        public static Bitmap catchBmp = null;

        // 是否保存
        private bool isSaved = true;

        // 绘图参数
        enum Tools { Pen, Text};
        Graphics catchBmpGraphics = null;  // 图形设备
        Color color = Color.White;  // 选择的颜色
        int penPixel = 5;   // 画笔像素
        int textPixel = 18; // 文字像素
        Tools selectTool = Tools.Pen; // 选择的工具，默认为画笔

        Point startPoint;   // 鼠标起始位置
        bool mouseDown = false; // 鼠标是否按下

        public Form1()
        {
            InitializeComponent();

            // 双缓冲
            this.SetStyle(ControlStyles.DoubleBuffer | ControlStyles.UserPaint |
                           ControlStyles.AllPaintingInWmPaint,
                           true);
            this.UpdateStyles();
        }

        // 更新图片显示
        private void UpdateScreen()
        {
            if (catchBmp != null)
                screenPic.Image = catchBmp;
        }

        #region 按钮事件
        // 颜色选择
        private void colorSelect_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
                colorSelect.BackColor = color;
            }
        }
        // 选择画笔
        private void penBtn_Click(object sender, EventArgs e)
        {
            selectTool = Tools.Pen;

            // 改变按钮样式
            penBtn.BackColor = Color.Wheat;
            textBtn.BackColor = SystemColors.ActiveCaption;
        }
        // 选择文字
        private void textBtn_Click(object sender, EventArgs e)
        {
            selectTool = Tools.Text;

            // 改变按钮样式
            penBtn.BackColor = SystemColors.ActiveCaption;
            textBtn.BackColor = Color.Wheat;
        }
        // 保存图片按钮
        private void saveBtn_Click(object sender, EventArgs e)
        {
            // 初始化保存文件对话框
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Bitmap|*.bmp";
            saveDialog.DefaultExt = "bmp";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // 保存图片
                System.IO.Stream stream = saveDialog.OpenFile();
                catchBmp.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                MessageBox.Show("保存成功！");

                stream.Flush();
                stream.Close();
            }

            isSaved = true;
        }        
        // 点击按钮开始捕捉屏幕
        private void printScrBtn_Click(object sender, EventArgs e)
        {
            // 新建一个截图窗口
            cutter = new Cutter();

            // 隐藏原窗口
            Hide();
            Thread.Sleep(200);

            // 设置截图窗口的背景图片
            Bitmap bmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(bmp.Width, bmp.Height));
            cutter.BackgroundImage = bmp;

            // 显示原窗口
            Show();

            // 显示截图窗口
            cutter.WindowState = FormWindowState.Maximized;
            cutter.ShowDialog();

            // 显示所截得的图片
            UpdateScreen();

            // 获取截图图片的图形设备
            catchBmpGraphics = Graphics.FromImage(catchBmp);

            isSaved = false;
        }
        #endregion

        // 画笔像素改变
        private void penPixelSelect_ValueChanged(object sender, EventArgs e)
        {
            penPixel = (int)penPixelSelect.Value;
        }

        // 文字像素改变
        private void textPixelSelect_ValueChanged(object sender, EventArgs e)
        {
            textPixel = (int)textPixelSelect.Value;
        }

        #region 鼠标事件
        // 截图编辑，鼠标按下
        private void screenPic_MouseDown(object sender, MouseEventArgs e)
        {
            if(catchBmp != null && e.Button == MouseButtons.Left)
            {
                mouseDown = true;

                // 根据选择的工具进行编辑
                switch(selectTool)
                {
                    case Tools.Pen:
                        catchBmpGraphics.FillEllipse(new SolidBrush(color), new Rectangle(e.X, e.Y, penPixel, penPixel));
                        break;
                    case Tools.Text:
                        startPoint = new Point(e.X, e.Y);
                        break;
                    default:
                        break;
                }

                screenPic.Image = catchBmp;
                Invalidate();
                Update();
            }
        }
        // 鼠标移动
        private void screenPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (catchBmp != null && e.Button == MouseButtons.Left && mouseDown == true)
            {
                // 根据选择的工具进行编辑
                switch (selectTool)
                {
                    case Tools.Pen:
                        catchBmpGraphics.FillEllipse(new SolidBrush(color), new Rectangle(e.X, e.Y, penPixel, penPixel));
                        break;
                    case Tools.Text:
                        // 绘制矩形区域
                        int rectX = Math.Min(startPoint.X, e.X);
                        int rectY = Math.Min(startPoint.Y, e.Y);
                        int width = Math.Abs(e.X - startPoint.X);
                        int height = Math.Abs(e.Y - startPoint.Y);
                        Rectangle rect = new Rectangle(rectX, rectY, width, height);
                        Pen pen = new Pen(Color.Wheat, 1);
                        Graphics g = screenPic.CreateGraphics();
                        g.DrawRectangle(pen, rect);
                        break;
                    default:
                        break;
                }

                screenPic.Image = catchBmp;
                Invalidate();
                Update();
            }
        }
        // 鼠标离开
        private void screenPic_MouseUp(object sender, MouseEventArgs e)
        {
            if(catchBmp != null && e.Button == MouseButtons.Left && mouseDown == true)
            {
                mouseDown = true;

                // 根据选择的工具进行编辑
                switch (selectTool)
                {
                    case Tools.Pen:
                        catchBmpGraphics.FillEllipse(new SolidBrush(color), new Rectangle(e.X, e.Y, penPixel, penPixel));
                        break;
                    case Tools.Text:
                        TextBox textBox = new TextBox()
                        {
                            Location = new Point(startPoint.X, startPoint.Y),
                            Size = new Size(e.X - startPoint.X, e.Y - startPoint.Y),
                            Multiline = true,
                            Font = new Font("宋体", textPixel)
                        };
                        textBox.KeyUp += (sende, ee) =>
                        {
                            if (ee.KeyCode == Keys.Enter)
                            {
                                // 获取并绘制文本
                                string str = textBox.Text;
                                catchBmpGraphics.DrawString(str, textBox.Font, new SolidBrush(color), startPoint);

                                // 移除文本框
                                screenPic.Controls.Remove(textBox);
                                textBox = null;
                            }
                        };
                        screenPic.Controls.Add(textBox);
                        break;
                    default:
                        break;
                }

                screenPic.Image = catchBmp;
                Invalidate();
                Update();
            }
        }
        #endregion

        // 程序关闭前，检查图片是否保存
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(isSaved == false)
            {
                DialogResult result = MessageBox.Show("Your still haven't save your picture. Would you want to save now?", " Warning", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    // 保存文件并退出
                    saveBtn.PerformClick();
                }
                else if(result == DialogResult.No)
                {
                    // 直接退出
                    e.Cancel = false;
                }
                else if(result == DialogResult.Cancel)
                {
                    // 取消退出
                    e.Cancel = true;
                }
            }
        }
    }
}
