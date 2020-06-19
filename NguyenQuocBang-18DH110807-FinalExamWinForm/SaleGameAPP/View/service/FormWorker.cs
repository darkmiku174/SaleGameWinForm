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
        private void ShowDataGridViewWorker()
        {
            DataProvider dp = new DataProvider();
            DataTable dttb = dp.SelectWorker();
            dgvWorker.AutoGenerateColumns = true;
            dgvWorker.DataSource = dttb;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
