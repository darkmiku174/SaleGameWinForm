using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleGameAPP.View.Service
{
    public partial class FormAddWorker : Form
    {
        private readonly SaleGameAPP.View.Service.FormWorker formParent;
        public FormAddWorker(SaleGameAPP.View.Service.FormWorker formParent)
        {
            InitializeComponent();
            rdGTNu.Checked = true;
            rdLoaiNV.Checked = true;
            this.formParent = formParent;
        }
        private bool CheckInput()
        {
            if (tbMSNV.Text == "" || tbTenNV.Text == "")
            {
                MessageBox.Show("Please type full information!!!");
                return false;
            }
            return true;
        }
        private void Clear()
        {
            tbMSNV.Text = "";
            tbTenNV.Text = "";
            rdGTNu.Checked = true;
            rdLoaiNV.Checked = true;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            DataProvider dp = new DataProvider();
            string MSNV = tbMSNV.Text;
            string tenNV = tbTenNV.Text;
            bool gioiTinh = rdGTNu.Checked;
            bool loai = rdLoaiNV.Checked;
            if (dp.CheckExistMSNV(MSNV))
            {
                MessageBox.Show("MSNV is exist");
                return;
            }
            dp.AddWorker(MSNV, tenNV, gioiTinh, loai);
            Clear();
            formParent.ShowDataGridViewWorker();
        }
    }
}
