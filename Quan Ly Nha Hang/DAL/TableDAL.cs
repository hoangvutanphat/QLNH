using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace Quan_Ly_Nha_Hang.DAL
{
     class TableDAL
    {
        private static TableDAL instance;

        public static TableDAL Instance {
            get { if (instance == null) instance = new TableDAL();
                return TableDAL.instance;
                        } 
            private set => instance = value; }

        private TableDAL() { }

        public static int TableWidth = 80;
        public static int TableHeight = 80;

        public void SwitchTable(int id1, int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @IdTable1 , @IdTable2", new object[] { id1, id2 });
        }
        public  List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("Exec dbo.USP_GetTableList");
            foreach( DataRow item in data.Rows)
            {
                Table table = new Table(item);
                tableList.Add(table);
            }

            return tableList;
        }

    }
}
