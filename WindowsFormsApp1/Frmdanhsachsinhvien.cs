﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmdanhsachsinhvien : Form
    {
        public Frmdanhsachsinhvien()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmadminmain f = new Frmadminmain();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }

        private void Frmdanhsachsinhvien_Load(object sender, EventArgs e)
        {

        }
    }
}
