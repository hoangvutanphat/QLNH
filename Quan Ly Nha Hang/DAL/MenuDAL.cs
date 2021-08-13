using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Quan_Ly_Nha_Hang.DTO;

namespace Quan_Ly_Nha_Hang.DAL
{
    public class MenuDAL
    {
        private static MenuDAL instance;

        public static MenuDAL Instance {
            get
            {
                if (instance == null)
                    instance = new MenuDAL();
                return MenuDAL.instance;
            }
            private set => instance = value; }

        private MenuDAL() { }

        public List<Menu> GetListMenuByTable(int id)
        {
            List<Menu> lstMenu = new List<Menu>();

            string query = "SELECT f.name, f.price, bi.count, f.price * bi.count as [totalPrice] FROM dbo.BillInfo as bi, dbo.Bill as b, dbo.Food as f Where bi.idBill = b.id AND b.status = 0 AND bi.idFood = f.id AND b.idTable = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                lstMenu.Add(menu);

            }
            return lstMenu;
        }
    }
}
