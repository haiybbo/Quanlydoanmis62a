﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_tim_kiem_do_an_sinh_vien : Form
    {
        public frm_tim_kiem_do_an_sinh_vien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmsinhvienmain yourthesis = new Frmsinhvienmain();
            yourthesis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudentprofile sp = new frmstudentprofile();
            sp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
