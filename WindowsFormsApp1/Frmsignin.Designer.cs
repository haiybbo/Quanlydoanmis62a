﻿
namespace WindowsFormsApp1
{
    partial class Frmsignin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmsignin));
            this.txtusername = new System.Windows.Forms.TextBox();
            this.btnsignin2 = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblquenmk = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtusername.Location = new System.Drawing.Point(665, 200);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Multiline = true;
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(457, 59);
            this.txtusername.TabIndex = 2;
            this.txtusername.UseWaitCursor = true;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnsignin2
            // 
            this.btnsignin2.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsignin2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnsignin2.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnsignin2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsignin2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsignin2.Location = new System.Drawing.Point(707, 515);
            this.btnsignin2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsignin2.Name = "btnsignin2";
            this.btnsignin2.Size = new System.Drawing.Size(155, 66);
            this.btnsignin2.TabIndex = 4;
            this.btnsignin2.Text = "Đăng nhập";
            this.btnsignin2.UseVisualStyleBackColor = false;
            this.btnsignin2.UseWaitCursor = true;
            this.btnsignin2.Click += new System.EventHandler(this.btnsignin2_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtpassword.Location = new System.Drawing.Point(665, 348);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(457, 53);
            this.txtpassword.TabIndex = 2;
            this.txtpassword.UseWaitCursor = true;
            this.txtpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.DimGray;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnexit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnexit.Location = new System.Drawing.Point(938, 515);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(141, 66);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Thoát";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.UseWaitCursor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblquenmk
            // 
            this.lblquenmk.AutoSize = true;
            this.lblquenmk.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.lblquenmk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblquenmk.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.lblquenmk.Location = new System.Drawing.Point(976, 416);
            this.lblquenmk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblquenmk.Name = "lblquenmk";
            this.lblquenmk.Size = new System.Drawing.Size(146, 25);
            this.lblquenmk.TabIndex = 5;
            this.lblquenmk.TabStop = true;
            this.lblquenmk.Text = "Quên mật khẩu";
            this.lblquenmk.UseWaitCursor = true;
            this.lblquenmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblquenmk_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(673, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên đăng nhập";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(673, 314);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            this.label2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(383, 44);
            this.label5.TabIndex = 12;
            this.label5.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            this.label5.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Quản_lý_đồ_án2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(50, 45);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(578, 545);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // Frmsignin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1203, 678);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblquenmk);
            this.Controls.Add(this.btnsignin2);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtpassword);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1228, 746);
            this.Name = "Frmsignin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frmsignin";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmsignin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button btnsignin2;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.LinkLabel lblquenmk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}