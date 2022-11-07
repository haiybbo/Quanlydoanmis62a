using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmsignin : Form
    {
        //chỉnh cursor default
        public Frmsignin()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsignin2_Click(object sender, EventArgs e)
        {
            string tentk = txtusername.Text;
            string matkhau = txtpassword.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from Taikhoan where tentaikhoan ='" + tentk + "' and matkhau = '" + matkhau + "'";

            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Quenmatkhau quenmatkhau = new Quenmatkhau();
            quenmatkhau.Show();
        }
    }
}
