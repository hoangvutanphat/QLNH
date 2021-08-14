using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DAL
{
    public class FoodDAL
    {
        private static FoodDAL instance;

        public static FoodDAL Instance {
            get { if (instance == null) instance = new FoodDAL();
                return FoodDAL.instance;
            }
            private set => instance = value; }

        private FoodDAL() { }

        public List<Food> GetFoodCategoryByID(int id)
        {
            List<Food> list = new List<Food>();
            string query = "Select * from dbo.Food where IdCategory = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;

        }
        public List<Food> GetListFood()
        {
            List<Food> list = new List<Food>();
            string query = "Select * from dbo.Food";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach(DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public List<Food> SearchFoodByName(string name)
        {
            List<Food> list = new List<Food>();
            string query = string.Format("select * from dbo.Food where [dbo].[fuChuyenCoDauThanhKhongDau](name) like N'%'+[dbo].[fuChuyenCoDauThanhKhongDau](N'{0}')+N'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Food food = new Food(item);
                list.Add(food);
            }
            return list;
        }
        public bool InsertFood(string name, int idCategory , int price)
        {
            string query = string.Format("INSERT dbo.Food ( name, IdCategory, Price ) Values( N'{0}' , {1} , {2})", name, idCategory, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UpdateFood(int idFood, string name, int idCategory, int price)
        {
            string query = string.Format("Update dbo.Food Set name = N'{0}', IdCategory = {1} ,Price = {2} where Id = {3}", name, idCategory, price, idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DeleteFood(int idFood)
        {
            BillInfoDAL.Instance.DeleteBillInfoByFoodID(idFood);

            string query = string.Format("Delete dbo.Food Where id = {0}",idFood);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
