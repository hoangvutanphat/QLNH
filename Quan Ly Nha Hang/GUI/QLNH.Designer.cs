
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbbTable = new System.Windows.Forms.ComboBox();
            this.SaleCount = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Foodcount = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flpTable = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleCount)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(898, 28);
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
            this.panel2.Controls.Add(this.lstBill);
            this.panel2.Location = new System.Drawing.Point(451, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 330);
            this.panel2.TabIndex = 2;
            // 
            // lstBill
            // 
            this.lstBill.HideSelection = false;
            this.lstBill.Location = new System.Drawing.Point(0, 3);
            this.lstBill.Name = "lstBill";
            this.lstBill.Size = new System.Drawing.Size(435, 315);
            this.lstBill.TabIndex = 0;
            this.lstBill.UseCompatibleStateImageBehavior = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbTable);
            this.panel3.Controls.Add(this.SaleCount);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.btnSale);
            this.panel3.Controls.Add(this.btnCheck);
            this.panel3.Location = new System.Drawing.Point(451, 437);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 79);
            this.panel3.TabIndex = 3;
            // 
            // cbbTable
            // 
            this.cbbTable.FormattingEnabled = true;
            this.cbbTable.Location = new System.Drawing.Point(15, 44);
            this.cbbTable.Name = "cbbTable";
            this.cbbTable.Size = new System.Drawing.Size(104, 24);
            this.cbbTable.TabIndex = 5;
            // 
            // SaleCount
            // 
            this.SaleCount.Location = new System.Drawing.Point(187, 44);
            this.SaleCount.Name = "SaleCount";
            this.SaleCount.Size = new System.Drawing.Size(98, 22);
            this.SaleCount.TabIndex = 4;
            this.SaleCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SaleCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = "Chuyển bàn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSale
            // 
            this.btnSale.Location = new System.Drawing.Point(187, 8);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(98, 30);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Giảm giá";
            this.btnSale.UseVisualStyleBackColor = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(328, 8);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(104, 63);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Thanh toán";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Foodcount);
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.comboBox2);
            this.panel4.Controls.Add(this.comboBox1);
            this.panel4.Location = new System.Drawing.Point(451, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 64);
            this.panel4.TabIndex = 4;
            // 
            // Foodcount
            // 
            this.Foodcount.Location = new System.Drawing.Point(349, 20);
            this.Foodcount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.Foodcount.Name = "Foodcount";
            this.Foodcount.Size = new System.Drawing.Size(68, 22);
            this.Foodcount.TabIndex = 2;
            this.Foodcount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm món";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 24);
            this.comboBox2.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(4, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // flpTable
            // 
            this.flpTable.AutoScroll = true;
            this.flpTable.Location = new System.Drawing.Point(13, 31);
            this.flpTable.Name = "flpTable";
            this.flpTable.Size = new System.Drawing.Size(428, 485);
            this.flpTable.TabIndex = 5;
            // 
            // QLNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 528);
            this.Controls.Add(this.flpTable);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "QLNH";
            this.Text = "Quản lý nhà hàng";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleCount)).EndInit();
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbbTable;
        private System.Windows.Forms.NumericUpDown SaleCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.FlowLayoutPanel flpTable;
    }
}