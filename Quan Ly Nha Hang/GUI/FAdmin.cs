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
        BindingSource categoryList = new BindingSource();
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
            dtgvCategory.DataSource = categoryList;
            LoadDateTimePickerBill();
            LoadListBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
            LoadListFood();
            LoadAccount();
            AddFoodBinding();
            LoadListCategory(cbbCategory);
            AddAccountBinding();
            LoadListCategory();
            AddCategoryBinding();
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvListBill.DataSource = BillDAL.Instance.GetListBillByDate(checkIn, checkOut);
            int totalPrice = 0;
            //foreach(DataRow item in BillDAL.Instance.GetListBillByDate(checkIn, checkOut).Rows)
            //{
            //    totalPrice += Convert.ToInt32(item.
            //}
            //Da co gang de dua tong tien len nhung khong duoc

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
        void AddCategoryBinding()
        {
            txbIDcate.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbnameCate.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "name", true, DataSourceUpdateMode.Never));
        }
        void LoadListCategory(ComboBox cb)
        {
            cb.DataSource = CategoryDAL.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }
        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAL.Instance.GetListCategory();
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
            else
            {
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
            
        }
        void AddCategory(string userName)
        {
            if (CategoryDAL.Instance.InsertCategory(userName))
            {
                MessageBox.Show("Thêm danh mục thành công");
            }
            else
            {
                MessageBox.Show("Thêm danh mục thất bại");
            }
            LoadListCategory();
        }
        void EditCategory(int id, string name)
        {
            if (CategoryDAL.Instance.UpdateCategory(id , name))
            {
                MessageBox.Show("Sửa danh mục thành công");
            }
            else
            {
                MessageBox.Show("Chỉnh sửa danh mục thất bại");
            }
            LoadListCategory();
        }
        void DeleteCategory(int id)
        {
            if (CategoryDAL.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xoá danh mục thành công");
            }
            else
            {
                MessageBox.Show("Xóa danh mục  thất bại");
            }
            LoadListCategory();
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
            if (txbUserName.Text==userName & (int)nmAccountType.Value ==1) 
            {
                EditAccount(userName, displayName, type);
            }
            else
            {
                MessageBox.Show("Không thể sửa thông tin tài khoản");
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            ResetPassword(username);
        }

        //private void btnFirstView_Click(object sender, EventArgs e)
        //{
        //    txbpage.Text = "1";
        //}

        //private void btnLastView_Click(object sender, EventArgs e)
        //{
        //    int sum = BillDAL.Instance.GetNumBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);

        //    int lastPage = sum / 10;
        //    if(sum % 10 != 0)
        //    {
        //        lastPage++;
        //    }
        //}
        //private void txbpage_TextChanged(object sender, EventArgs e)
        //{
        //    dtgvListBill.DataSource = BillDAL.Instance.GetListBillByDateAndPage(dateTimePicker1.Value, dateTimePicker2.Value, Convert.ToInt32(txbpage.Text));
        //}
        //private void btnPrevious_Click(object sender, EventArgs e)
        //{
        //    int page = Convert.ToInt32(txbpage.Text);
        //    if (page > 1)
        //        page--;
        //    txbpage.Text = page.ToString();
        //}
        //private void btnNext_Click(object sender, EventArgs e)
        //{
        //    int page = Convert.ToInt32(txbpage.Text);
        //    int sum = BillDAL.Instance.GetNumBillByDate(dateTimePicker1.Value, dateTimePicker2.Value);
        //    if (page < sum)
        //        page++;
        //    txbpage.Text = page.ToString();
        //}
        
        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDcate.Text);
            string name = txbnameCate.Text;
            EditCategory(id, name);
            LoadListCategory(cbbCategory);
        }
        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbIDcate.Text);
            DeleteCategory(id);
            LoadListCategory(cbbCategory);
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbnameCate.Text;
            AddCategory(name);
            LoadListCategory(cbbCategory);
        }
        //private void FAdmin_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    QLNH qlnh = new QLNH(loginAccount);
        //    qlnh.ShowDialog();
        //}
        private void FAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            QLNH qlnh = new QLNH(loginAccount);
            this.Hide();
            qlnh.ShowDialog();           
        }

        

        #endregion

        
    }
}
