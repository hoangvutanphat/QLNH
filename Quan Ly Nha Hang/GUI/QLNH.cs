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
        private Account loginAccount;

        public Account LoginAccount
        {
            get 
            {
                return loginAccount;
            }
            set
            {
                loginAccount = value;
                ChangeAccount(loginAccount.Type);
            }
        }
        

        public QLNH(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
            loadTable();
            LoadCategory();
            LoadCbbTable(cbbTable);
        }
        #region Methods
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinCáNhânToolStripMenuItem.Text += " (" + LoginAccount.DisplayName + ")";
        }
        void LoadCategory() {
            List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
            cbbCategory.DataSource = listCategory;
            cbbCategory.DisplayMember = "name";

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
            txbTotalPrice.Text = totalPrice.ToString() ;
            
        }

        public void LoadCbbTable(ComboBox cb)
        {
            cb.DataSource = TableDAL.Instance.LoadTableList();
            cb.DisplayMember = "Name";
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
            txbBan.Text = tableID.ToString();
            lstBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FIdentify f = new FIdentify(loginAccount);
            f.UpdateAccount += F_UpdateAccount1;
            f.ShowDialog();
        }

        private void F_UpdateAccount1(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thoong tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FAdmin f = new FAdmin();
            f.loginAccount = LoginAccount;
            f.InsertFood += F_InsertFood;
            f.DeleteFood += F_DeleteFood;
            f.UpdateFood += F_UpdateFood;
            this.Hide();
            f.ShowDialog();
            
        }

        private void F_UpdateFood(object sender, EventArgs e)
        {
            if (lstBill.Tag != null)
                LoadFoodListCategoryByID((cbbCategory.SelectedItem as Category).ID);
            ShowBill((lstBill.Tag as Table).ID);
        }

        private void F_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListCategoryByID((cbbCategory.SelectedItem as Category).ID);
            if(lstBill.Tag !=null)
                ShowBill((lstBill.Tag as Table).ID);
                loadTable();
        }

        private void F_InsertFood(object sender, EventArgs e)
        {
            if (lstBill.Tag != null)
                LoadFoodListCategoryByID((cbbCategory.SelectedItem as Category).ID);
                ShowBill((lstBill.Tag as Table).ID);
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
            if (table == null)
            {
                MessageBox.Show("Hãy chọn bàn!");
                return;
            }
            try
            {

            int foodId = (cbbFood.SelectedItem as Food).ID;
            int count = (int)Foodcount.Value;
            int idBill = BillDAL.Instance.GetUnCheckOutBillByTableId(table.ID);
            if (idBill == -1)
                {
                    BillDAL.Instance.InsertBill(table.ID);
                    BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxID(), foodId, count);//Them vao bang Billinfo theo id lon nhat
                }
                else
                {
                    BillInfoDAL.Instance.InsertBillInfo(idBill, foodId, count);
                }
                ShowBill(table.ID);
                loadTable();
            }
            catch {
            }
            
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            Table table = lstBill.Tag as Table;
            int Bill = BillDAL.Instance.GetUnCheckOutBillByTableId(table.ID);

            int totalPrice = Convert.ToInt32(txbTotalPrice.Text);

            if (Bill != -1)//Bill chua co
            {
                if (MessageBox.Show("Bạn có muốn thanh toán hóa đơn cho " + table.Name + " ?", "Thông báo", MessageBoxButtons.OKCancel)
                    == System.Windows.Forms.DialogResult.OK) 
                {
                    BillDAL.Instance.CheckOut(Bill, totalPrice);
                    ShowBill(table.ID);
                    loadTable();
                }
         
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id1 = (lstBill.Tag as Table).ID;
            int id2 = (cbbTable.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn thực sự muốn chuyển từ bàn {0} sang bàn {1}", id1, id2), "Thông báo", MessageBoxButtons.OKCancel)
                ==System.Windows.Forms.DialogResult.OK)
            { TableDAL.Instance.SwitchTable(id1, id2);
                loadTable();
            }
        }



        #endregion

       
    }
}
