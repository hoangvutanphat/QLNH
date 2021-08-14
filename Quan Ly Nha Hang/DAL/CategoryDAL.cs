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
        public Category GetCategoryById(int id)
        {
            Category category = null;
            string query = "select * from dbo.FoodCategory where id =" +id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                category = new Category(item);
                return category;
            }
            return category;
        }
        public bool InsertCategory(string name)
        {
            string query = string.Format("exec USP_insertcategory @name = N'{0}'", name);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            string query = string.Format("Update dbo.FoodCategory Set name = N'{0}' where Id = {1}", name, id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteCategory(int id)
        {          
            string query = string.Format("Delete dbo.FoodCategory Where id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
