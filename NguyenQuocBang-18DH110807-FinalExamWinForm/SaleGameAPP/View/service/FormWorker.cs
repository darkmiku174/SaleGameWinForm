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
    public partial class FormWorker : Form
    {
        public FormWorker()
        {
            InitializeComponent();
        }
        private void FormWorker_Load(object sender, EventArgs e)
        {
            ShowDataGridViewWorker();
        }
        public void ShowDataGridViewWorker()
        {
            DataProvider dp = new DataProvider();
            DataTable dttb = dp.SelectWorker();
            dgvWorker.AutoGenerateColumns = true;
            dgvWorker.DataSource = dttb;
        }
        private void ShowDataGridViewHistoryLogin()
        {
            bool checkStartEnd = dateTimeStart.Text == dateTimeEnd.Text ? true : false;
            DataProvider dp = new DataProvider();
            DataTable dttb = new DataTable();
            if (checkStartEnd)
            {
                dttb = dp.SelectHistoryLogin();
            }
            else
            {
                dttb = dp.SelectHistoryLoginStartEnd(dateTimeStart.Text,dateTimeEnd.Text);
            }
            dgvLoginHis.AutoGenerateColumns = true;
            dgvLoginHis.DataSource = dttb;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SaleGameAPP.View.Service.FormAddWorker formAddWorker = new View.Service.FormAddWorker(this);
            formAddWorker.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete worker?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            DataProvider dp = new DataProvider();
            string MSNV = dgvWorker.CurrentRow.Cells["MSNV"].Value.ToString();
            dp.DeleteWorker(MSNV);
            ShowDataGridViewWorker();
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {
            ShowDataGridViewHistoryLogin();
        }
    }
}
