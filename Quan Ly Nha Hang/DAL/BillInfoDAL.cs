using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DAL
{
    public class BillInfoDAL
    {
        private static BillInfoDAL instance;

        public static BillInfoDAL Instance {
            get { if (instance == null) instance = new BillInfoDAL();
                return instance;
            }
            private set => instance = value; }

        private BillInfoDAL() { }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();
            string query = "SELECT * from dbo.BillInfo where idBill = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }
        public void InsertBillInfo(int idBill, int idFood, int count)
        {
            DataProvider.Instance.ExecuteNonQuery("USP_InsertBillInfo @IdBill , @IdFood , @count ", new object[] { idBill, idFood, count });
        }
    }
    

}
