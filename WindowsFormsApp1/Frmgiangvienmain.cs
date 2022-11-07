using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmgiangvienmain : Form
    {
        public Frmgiangvienmain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmprofilegiangvien f = new Frmprofilegiangvien();
            f.Show();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Frmtrogiup_giangvien f = new Frmtrogiup_giangvien();
            f.Show();
        }
    }
}
