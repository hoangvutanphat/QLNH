using Quan_Ly_Nha_Hang.DAL;
using Quan_Ly_Nha_Hang.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Nha_Hang
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txbUsername.Text;
            string passWord = txbPassword.Text;
            if (Login(userName,passWord))
            {
                QLNH f2 = new QLNH();
                this.Hide();
                f2.ShowDialog();//on top
                this.Show();
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu bạn nhập vào sai!!");
           
        }

        bool Login(string userName, string passWord)
        {
            return AccountDAL.Instance.Login(userName,passWord);
        }

        private void FLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel)
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
            //khi khong nhan OK khong duoc phep thoat chuong trinh
        }

       
    }
}
