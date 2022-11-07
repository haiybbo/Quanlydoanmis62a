using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmdanhsachgiangvien : Form
    {
        public Frmdanhsachgiangvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmsinhvienmain f = new Frmsinhvienmain();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmstudentprofile f = new frmstudentprofile();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_tim_kiem_do_an_sinh_vien f = new frm_tim_kiem_do_an_sinh_vien();
            f.Show();
        }

        private void Frmdanhsachgiangvien_Load(object sender, EventArgs e)
        {

        }
    }
}
