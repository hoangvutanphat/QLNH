using Quan_Ly_Nha_Hang.DAL;
using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Nha_Hang.GUI
{
    public partial class FIdentify : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount);
            }
        }
        public FIdentify(Account acc)
        { 
            InitializeComponent();

            LoginAccount = acc;
        }
        void ChangeAccount(Account loginAccount)
        {
            txbUserName.Text = loginAccount.UserName;
            txbDisplayName.Text = loginAccount.DisplayName;
        }
        void UpdateAccountInfo()
        {
            string displayName = txbDisplayName.Text;
            string password = txbPassword.Text;
            string newpass = txbnewpass.Text;
            string renewpass = txbrenewpass.Text;
            string username = txbUserName.Text;
            
            if(newpass!=renewpass)
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng");
            }
            else
            {
                if (AccountDAL.Instance.UpdateAccount(username, displayName, password, newpass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAL.Instance.GetAccountByUserName(username)));
                }
                else
                    MessageBox.Show("Vui lòng điền đúng mật khẩu");
            }
        }
        //event chuyen du lieu tu form con ve form cha
        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }
    }
    public class AccountEvent : EventArgs
    {
        private Account acc;

        public Account Acc { get => acc; set => acc = value; }

        public AccountEvent(Account acc)
        {
            this.Acc = acc;
        }
    }
}
