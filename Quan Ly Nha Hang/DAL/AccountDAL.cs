using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

            string query = "Select * from dbo.Account where UserName = N'"+userName+"' and Password = N'"+passWord+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            return result.Rows.Count > 0;
        }
    }
}
