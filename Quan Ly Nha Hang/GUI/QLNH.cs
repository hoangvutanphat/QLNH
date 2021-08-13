using Quan_Ly_Nha_Hang.DAL;
using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Menu = Quan_Ly_Nha_Hang.DTO.Menu;

namespace Quan_Ly_Nha_Hang.GUI
{
    public partial class QLNH : Form
    {
        public QLNH()
        {
            InitializeComponent();
            loadTable();
            LoadCategory();
        }
        #region Methods
        void LoadCategory() {
            List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "name";

        }
        void LoadFoodListCategory() { 
        }
        void LoadFoodListCategoryByID(int id) {
            List<Food> listFood = FoodDAL.Instance.GetFoodCategoryByID(id);
            cbbFood.DataSource = listFood;
            cbbFood.DisplayMember = "Name";
        }

        void loadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAL.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Gray;
                        break;
                    default:
                        btn.BackColor = Color.Aquamarine;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lstBill.Items.Clear();

            List<Menu> listBillInfo = MenuDAL.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            { 

                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lstBill.Items.Add(lsvItem);
            }
            txbTotalPrice.Text = totalPrice.ToString() + " VND";
            
        }
        

        #endregion
        #region Events
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lstBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIdentify f = new FIdentify();
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin f = new FAdmin();
            f.ShowDialog();
        }
        private void cbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
                if(cb.SelectedItem == null)
            {
                return;
            }
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;

            LoadFoodListCategoryByID(id);

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lstBill.Tag as Table;//Lay bill cua table hien tai
            int foodId = (cbbFood.SelectedItem as Food).ID;
            int count = (int)Foodcount.Value;

            int idBill = BillDAL.Instance.GetUnCheckOutBillByTableId(table.ID);
               if (idBill == -1)
                {
                BillDAL.Instance.InsertBill(table.ID);
                BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxID(),foodId,count);//Them vao bang Billinfo theo id lon nhat
                }
               else
            {
                BillInfoDAL.Instance.InsertBillInfo(idBill, foodId, count);
            }
            ShowBill(table.ID);
            loadTable();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Table table = lstBill.Tag as Table;
            int Bill = BillDAL.Instance.GetUnCheckOutBillByTableId(table.ID);

            if (Bill != -1)//Bill chua co
            {
                if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho " + table.Name + " ?", "Thông báo", MessageBoxButtons.OKCancel)
                    == System.Windows.Forms.DialogResult.OK) ;
                {
                    BillDAL.Instance.CheckOut(Bill);
                    ShowBill(table.ID);
                    loadTable();
                }
            }
            
        }



        #endregion


    }
}
