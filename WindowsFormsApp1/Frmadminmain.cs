﻿using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmadminmain : Form
    {
        public Frmadminmain()
        {
            InitializeComponent();
        }

        private void Frmadminmain_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frmdanhsachsinhvien f = new Frmdanhsachsinhvien();
            f.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_tim_kiem_do_an_sinh_vien f = new frm_tim_kiem_do_an_sinh_vien();
            f.Show();

        }
    }
}
