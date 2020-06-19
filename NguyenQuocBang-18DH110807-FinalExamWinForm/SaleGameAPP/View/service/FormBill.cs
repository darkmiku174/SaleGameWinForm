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
    public partial class FormBill : Form
    {
        public FormBill()
        {
            InitializeComponent();
        }
        private void FormBill_Load(object sender, EventArgs e)
        {
            ShowDataGridViewBill();
        }
        private void ShowDataGridViewBill()
        {
            DataProvider dp = new DataProvider();
            DataTable dttb = dp.SelectBill();
            dgvBill.AutoGenerateColumns = true;
            dgvBill.DataSource = dttb;
        }
        private void ShowDataGridViewShowBill(string MSDH)
        {
            DataProvider dp = new DataProvider();
            DataTable dttb = dp.SelectCart(MSDH);
            dgvShowBill.AutoGenerateColumns = true;
            dgvShowBill.DataSource = dttb;
        }
        private void btnShow_Click(object sender, EventArgs e)
        {
            string MSDH = dgvBill.CurrentRow.Cells["MSDH"].Value.ToString();
            ShowDataGridViewShowBill(MSDH);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete bill?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            DataProvider dp = new DataProvider();
            string MSDH= dgvBill.CurrentRow.Cells["MSDH"].Value.ToString();
            dp.DeleteCart(MSDH);
            ShowDataGridViewBill();
            dgvShowBill.DataSource = null;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            DataTable dttb = new DataTable();
            bool checkStartEnd = dateTimeStart.Text != dateTimeEnd.Text ? true : false;
            if(checkStartEnd)
            {
                dttb = dp.SearchBillStartEnd(dateTimeStart.Text, dateTimeEnd.Text);
            }
            else
            {
                dttb = dp.SearchBillOneDay(dateTimeStart.Text);
            }    
            dgvBill.DataSource = dttb;
        }    
    }
}
