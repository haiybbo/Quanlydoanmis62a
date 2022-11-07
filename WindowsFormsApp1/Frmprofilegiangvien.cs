using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmprofilegiangvien : Form
    {
        public Frmprofilegiangvien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmgiangvienmain f = new Frmgiangvienmain();
            f.Show();
        }
    }
}
