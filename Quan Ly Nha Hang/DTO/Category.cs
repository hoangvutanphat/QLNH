using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DTO
{
    public class Category
    {
        private int iD;

        private string name;

        public Category(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }
        public Category(DataRow row)
        {
            this.ID = (int)row["Id"];
            this.Name = row["name"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
    }
}
