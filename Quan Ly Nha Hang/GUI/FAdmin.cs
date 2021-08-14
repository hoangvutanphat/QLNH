using Quan_Ly_Nha_Hang.DAL;
using Quan_Ly_Nha_Hang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Quan_Ly_Nha_Hang.GUI
{
    public partial class FAdmin : Form
    {
        BindingSource foodList = new BindingSource();//Giu ket noi binding
        BindingSource accountList = new BindingSource();
        public Account loginAccount;//K cho xoa tai khoan hien tai
        public FAdmin()
        {
            InitializeComponent();
            Load();

        }
        #region Methods
        void Load()
        {
            dgrvFood.DataSource = foodList;
            dtgvAccount.DataSource = accountList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            LoadListFood();
            LoadAccount();
            AddFoodBinding();
            LoadListCategory(cbbCategory);
            AddAccountBinding();
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvListBill.DataSource = BillDAL.Instance.GetListBillByDate(checkIn, checkOut);

        }
        void LoadListFood()
        {
            foodList.DataSource = FoodDAL.Instance.GetListFood();
        }

        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dateTimePicker1.Value = new DateTime ( today.Year, today.Month, 1 );
            dateTimePicker2.Value = dateTimePicker1.Value.AddMonths(1).AddDays(-1);
        }
        void AddFoodBinding()
        {
            txbFoodName.DataBindings.Add(new Binding("Text", dgrvFood.DataSource, "name", true,DataSourceUpdateMode.Never));
            txbIDFood.DataBindings.Add(new Binding("Text", dgrvFood.DataSource, "Id", true, DataSourceUpdateMode.Never));
            nmPrice.DataBindings.Add(new Binding("Value", dgrvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }
        void AddAccountBinding()
        {
            txbUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txbDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }
            void LoadAccount() 
        {
            accountList.DataSource = AccountDAL.Instance.GetListAccount();
        }
        void LoadListCategory(ComboBox cb)
        {
            cb.DataSource = CategoryDAL.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void AddAccount(string userName, string displayName , int type)
        {
            if(AccountDAL.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }
        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAL.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa tài khoản thất bại");
            }
            LoadAccount();
        }
        void DeleteAccount(string userName)
        {
            if (loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Không thể xóa tài khoản đang đăng nhập");
            }
           
                if (AccountDAL.Instance.DeleteAccount(userName))
                {
                    MessageBox.Show("Xoá tài khoản thành công");
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
                LoadAccount();
            
            
        }
        void ResetPassword(string userName)
        {
            if (AccountDAL.Instance.ResetPassword(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu cho tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu cho tài khoản thất bại");
            }
            LoadAccount();
        }
        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAL.Instance.SearchFoodByName(name);

            return listFood;
        }
        #endregion
        #region Events
        private void button1_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        }
        private void btnShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }
        private void txbIDFood_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgrvFood.SelectedCells.Count > 0 & dgrvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value!=null )
                {
                    int id = (int)dgrvFood.SelectedCells[0].OwningRow.Cells["IdCategory"].Value;

                    Category category = CategoryDAL.Instance.GetCategoryById(id);

                    cbbCategory.SelectedItem = category;
                    int index = -1;
                    int i = 0;
                    foreach (Category item in cbbCategory.Items)
                    {
                        if (item.ID == category.ID)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cbbCategory.SelectedIndex = index;
                }
            }catch {
                
            }

        }
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int idCategory = (cbbCategory.SelectedItem as Category).ID;
            int price = (int)nmPrice.Value;

            if (FoodDAL.Instance.InsertFood(name, idCategory, price))
            {
                MessageBox.Show("Cập nhật món thành công!");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi thêm thức ăn");
                //LoadListFood();
            }
        }

        private void btnUpdateFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int idCategory = (cbbCategory.SelectedItem as Category).ID;
            int price = (int)nmPrice.Value;
            int idFood = Convert.ToInt32(txbIDFood.Text);

            if (FoodDAL.Instance.UpdateFood(idFood, name, idCategory, price))
            {
                MessageBox.Show("Sửa món thành công!");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa thức ăn");
            }
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {

            int idFood = Convert.ToInt32(txbIDFood.Text);

            if (FoodDAL.Instance.DeleteFood(idFood))
            {
                MessageBox.Show("Xoá món thành công!");
                LoadListFood();
                if (deleteFood != null)
                    deleteFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa món ăn");
            }
        }

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }
        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }
        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFood.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;
            AddAccount(userName, displayName, type);

        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            
            DeleteAccount(userName);
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string displayName = txbDisplayName.Text;
            int type = (int)nmAccountType.Value;
            EditAccount(userName, displayName, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            ResetPassword(username);
        }

        #endregion

        
    }
}
