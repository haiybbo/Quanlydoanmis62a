using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmstudentprofile : Form
    {
        public frmstudentprofile()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdoancuaban yourthesis = new Frmdoancuaban();
            yourthesis.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tim_kiem_do_an_sinh_vien s = new frm_tim_kiem_do_an_sinh_vien();
            s.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmdanhsachgiangvien f = new Frmdanhsachgiangvien();
            f.Show();
        }
    }
}
