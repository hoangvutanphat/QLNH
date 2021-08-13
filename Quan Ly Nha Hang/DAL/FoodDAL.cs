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
    }
}
