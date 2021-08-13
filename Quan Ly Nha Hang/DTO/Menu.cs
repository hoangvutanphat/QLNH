using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DTO
{
    public class Menu
    {
        private string foodName;
        private int count;
        private float price;
        private float totalPrice;

        public string FoodName { get => foodName; set => foodName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }

        public Menu(string foodName, float price, int count ,float totalPrice = 0)
        {
            this.FoodName = foodName;
            this.Price = price;
            this.Count = count;
            this.TotalPrice = totalPrice;
        }

        public Menu(DataRow row)
        {
            this.FoodName = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["price"].ToString());
            this.Count = (int)row["count"];
            this.TotalPrice = (float)Convert.ToDouble(row["totalPrice"].ToString());
        }


    }
}
