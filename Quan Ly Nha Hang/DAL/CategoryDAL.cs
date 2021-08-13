using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DAL
{
    public class CategoryDAL
    {
        private static CategoryDAL instance;

        public static CategoryDAL Instance {
            get { if (instance == null) 
                instance = new CategoryDAL();
                return CategoryDAL.instance;
            } 
            private set => instance = value; }

        private CategoryDAL() { }
        public  List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();
            string query = "Select * from dbo.FoodCategory";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);
                list.Add(category);
            }
            return list;
        } 
    }
}
