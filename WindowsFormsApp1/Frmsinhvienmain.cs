using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmsinhvienmain : Form
    {
        public Frmsinhvienmain()
        {
            InitializeComponent();
        }

        private void Frmdoancuaban_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudentprofile sp = new frmstudentprofile();
            sp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tim_kiem_do_an_sinh_vien search = new frm_tim_kiem_do_an_sinh_vien();
            search.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }
    }
}
