﻿namespace WindowsFormsApp1
{
    class Taikhoan
    {
        private string tentaikhoan;
        private string matkhau;

        public Taikhoan()
        { }

        public Taikhoan(string tentaikhoan, string matkhau)
        {
            this.tentaikhoan = tentaikhoan;
            this.matkhau = matkhau;
        }

        public string Tentaikhoan { get => tentaikhoan; set => tentaikhoan = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
    }
}
