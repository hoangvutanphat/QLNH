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

namespace Quan_Ly_Nha_Hang.GUI
{
    public partial class QLNH : Form
    {
        public QLNH()
        {
            InitializeComponent();
            loadTable();
        }
        #region Methods
        void loadTable()
        {
            List<Table> tableList = TableDAL.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                switch(item.Status)
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

        #endregion
        #region Events
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion
    }
}
