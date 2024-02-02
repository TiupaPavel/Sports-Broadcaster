using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace Sports_Broadcaster
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 320);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(190, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(159, 68);
            this.button4.TabIndex = 9;
            this.button4.Text = "Donate";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.DonateButton_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button5.Location = new System.Drawing.Point(190, 132);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(159, 68);
            this.button5.TabIndex = 8;
            this.button5.Text = "2Sport";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.FifthButton_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button6.Location = new System.Drawing.Point(190, 43);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(159, 68);
            this.button6.TabIndex = 7;
            this.button6.Text = "Live Tv";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.FourthButton_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(25, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 68);
            this.button3.TabIndex = 6;
            this.button3.Text = "LiveBall";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ThirdButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(25, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "FSL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.SecondButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(25, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 68);
            this.button1.TabIndex = 4;
            this.button1.Text = "My Football";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Sports Broadcaster";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 52);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click_1);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 344);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sports Broadcaster";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            // Створюємо градієнтний кисть
            LinearGradientBrush gradientBrush = new LinearGradientBrush(
                groupBox1.ClientRectangle,
                Color.Gray, // Верхній колір (білий)
                Color.DarkGray, // Нижній колір (зелений)
                LinearGradientMode.Vertical); // Вказуємо вертикальний градієнт

            // Використовуючи кисть, заповнюємо прямокутник градієнтом
            e.Graphics.FillRectangle(gradientBrush, groupBox1.ClientRectangle);
        }

        private void OpenToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = true;
            WindowState = FormWindowState.Normal;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Закрыть приложение
        }

        private Form1 form1 = null;

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (form1 == null || form1.IsDisposed)
                {
                    form1 = new Form1();
                    form1.FormClosed += (s, args) => form1 = null;
                    form1.Show();
                }
                else
                {
                    form1.WindowState = FormWindowState.Normal;
                    form1.Activate();
                }
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            string url = "https://myfootball.top/";
            Process.Start(url);
        }

        private void SecondButton_Click(object sender, EventArgs e)
        {
            string url = "https://d.fsl-stream.im/football-streamz5/";
            Process.Start(url);
        }

        private void ThirdButton_Click(object sender, EventArgs e)
        {
            string url = "https://liveball.uno/";
            Process.Start(url);
        }

        private void FourthButton_Click(object sender, EventArgs e)
        {
            string url = "https://livetv754.me/enx/";
            Process.Start(url);
        }

        private void FifthButton_Click(object sender, EventArgs e)
        {
            string url = "https://2sport.tv/";
            Process.Start(url);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle titleBarRect = new Rectangle(0, 0, this.Width, SystemInformation.CaptionHeight);
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), titleBarRect);
        }

        private void DonateButton_Click(object sender, EventArgs e)
        {
            string donationUrl = "https://www.privat24.ua/send/bknjp";
            Process.Start(donationUrl);
        }
        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}

