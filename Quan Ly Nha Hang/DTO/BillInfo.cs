using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Quan_Ly_Nha_Hang.DTO
{
    public class BillInfo
    {
        private int idBill;
        private int idFood;
        private int count;

        public BillInfo(int idBill , int idFood, int count)
        {
            this.IdBill = idBill;
            this.IdFood = idFood;
            this.Count = count;
        }

        public BillInfo(DataRow row)
        {
            this.IdBill = (int)row["idBill"];
            this.IdFood = (int)row["idFood"];
            this.Count = (int)row["count"];
        }
        public int IdBill { get => idBill; set => idBill = value; }
        public int IdFood { get => idFood; set => idFood = value; }
        public int Count { get => count; set => count = value; }
    }
}
