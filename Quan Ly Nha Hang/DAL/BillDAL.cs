using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DAL
{
    public class BillDAL
    {
        private static BillDAL instance;

        public static BillDAL Instance {
            get { if (instance == null)
                      instance = new BillDAL();
                return BillDAL.instance;
            }
            private set => instance = value; 
        }
    
        private BillDAL() { }
        //Trả về id bill theo id table, lỗi trả về -1
        public int GetUnCheckOutBillByTableId(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.bill where idTable = " + id + " and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.ID;
            }
            return -1;
        }
        public void InsertBill(int id)
        {
            DataProvider.Instance.ExecuteNonQuery("exec USP_InsertBill @IdTable  ", new object[]{id});
        }
        public int GetMaxID()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(Id) FROM dbo.Bill");
            }
            catch
            {
                return 1;
            }
        }
        public void CheckOut(int id)
        {
            string query = "UPDATE dbo.Bill SET status = 1 Where Id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
