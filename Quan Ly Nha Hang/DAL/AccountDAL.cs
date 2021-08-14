using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Quan_Ly_Nha_Hang.DAL
{
    public class AccountDAL
    {
        private static AccountDAL instance;
        public static AccountDAL Instance { 
            get { if (instance == null) instance = new AccountDAL();
                return AccountDAL.instance;       
            } 
            private set => instance = value; 
        }
        private AccountDAL() { }
        public bool Login(string userName, string passWord)
        {
            //ma hoa mat khau
            //byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
            //byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            //string hasPass = "";
            //foreach(byte item in hasData)
            //{
            //    hasPass += item;
            //}
            //var list = hasData.ToString();
            //list.Reverse();
            //hasData = list.ToArray();
            //Do dinh nghia kieu du lieu ben password ngan => Chua thuc hien duoc buoc nay

            string query = "Select * from dbo.Account where UserName = N'"+userName+"' and Password = N'"+passWord+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
        public bool UpdateAccount(string userName, string displayName, string pass, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @UserName  , @DisplayName , @password , @newPassword ", new object[] { userName, displayName, pass, newPass});
            return result > 0;
        }
        public DataTable GetListAccount()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select UserName , DisplayName , Type from dbo.Account");
            return data; 
        }
        public Account GetAccountByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.Account where UserName ='" + userName+"'");
            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }
            return null;
        }
        public bool InsertAccount(string name, string displayName, int type)
        {
            string query = string.Format("INSERT dbo.Account ( UserName, DisplayName, Type ) Values( N'{0}' , N'{1}' , N'{2}')", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateAccount(string name, string displayName, int type)
        {
            string query = string.Format("Update dbo.Account Set DisplayName = N'{1}', Type = {2} where UserName = N'{0}'", name, displayName, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteAccount(string name)
        {
          

            string query = string.Format("Delete dbo.Account Where UserName = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool ResetPassword(string name)
        {
            string query = string.Format("Update dbo.Account set Password = N'1' where Username = N'{0}'",name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
