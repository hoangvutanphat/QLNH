
namespace Quan_Ly_Nha_Hang.GUI
{
    partial class QLNH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstBill = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Foodcount = new System.Windows.Forms.NumericUpDown();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.cbbFood = new System.Windows.Forms.ComboBox();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBan = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foodcount)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(899, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbBan);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lstBill);
            this.panel2.Location = new System.Drawing.Point(451, 101);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 330);
            this.panel2.TabIndex = 2;
            // 
            // lstBill
            // 
            this.lstBill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(0, 2);
            this.lstBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(435, 292);
            this.lstBill.TabIndex = 0;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            this.lstBill.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            this.columnHeader1.Width = 87;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Đơn giá";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượng";
            this.columnHeader3.Width = 67;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            this.columnHeader4.Width = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tổng tiền";
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalPrice.Location = new System.Drawing.Point(121, 41);
            this.txbTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.ReadOnly = true;
            this.txbTotalPrice.Size = new System.Drawing.Size(211, 27);
            this.txbTotalPrice.TabIndex = 6;
            this.txbTotalPrice.Text = "0";
            this.txbTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbTotalPrice);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cbbTable);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Location = new System.Drawing.Point(451, 437);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 79);
            this.panel3.TabIndex = 3;
            // 
            // cbbTable
            // 
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(4, 44);
            this.cbbTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(107, 24);
            this.cbbTable.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Chuyển bàn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(339, 7);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(93, 63);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.Foodcount);
            this.panel4.Controls.Add(this.btnAddFood);
            this.panel4.Controls.Add(this.cbbFood);
            this.panel4.Controls.Add(this.cbbCategory);
            this.panel4.Location = new System.Drawing.Point(451, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 64);
            this.panel4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Món ăn :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh mục :";
            // 
            // Foodcount
            // 
            this.Foodcount.Location = new System.Drawing.Point(361, 20);
            this.Foodcount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Foodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Foodcount.Name = "Foodcount";
            this.Foodcount.Size = new System.Drawing.Size(56, 22);
            this.Foodcount.TabIndex = 2;
            this.Foodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(252, 2);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(91, 54);
            this.btnAddFood.TabIndex = 1;
            this.btnAddFood.Text = "Thêm món";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // cbbFood
            // 
            this.cbbFood.FormattingEnabled = true;
            this.cbbFood.Location = new System.Drawing.Point(101, 33);
            this.cbbFood.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbFood.Name = "cbbFood";
            this.cbbFood.Size = new System.Drawing.Size(144, 24);
            this.cbbFood.TabIndex = 0;
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(101, 2);
            this.cbbCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(144, 24);
            this.cbbCategory.TabIndex = 0;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(13, 31);
            this.flpTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(428, 485);
            this.flpTable.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bàn :";
            // 
            // txbBan
            // 
            this.txbBan.Location = new System.Drawing.Point(51, 302);
            this.txbBan.Name = "txbBan";
            this.txbBan.Size = new System.Drawing.Size(103, 22);
            this.txbBan.TabIndex = 2;
            this.txbBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // QLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 528);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QLNH";
            this.Text = "Quản lý nhà hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foodcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lstBill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.NumericUpDown Foodcount;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.ComboBox cbbFood;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbBan;
    }
}