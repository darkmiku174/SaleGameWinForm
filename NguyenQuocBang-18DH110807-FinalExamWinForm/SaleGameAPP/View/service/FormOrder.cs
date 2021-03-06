﻿using System;
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
    public partial class FormOrder : Form
    {
        private string MSDH = "";
        public FormOrder()
        {
            InitializeComponent();
        }
        private void FormOrder_Load(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            MSDH = dp.CurrentMSDH();
            ShowDataGridView(MSDH);
            MoneyNeedToBuy();
        }
        private void ShowDataGridView(string MSDH)
        {
            DataProvider dp = new DataProvider();
            DataTable dttb = dp.SelectCart(MSDH);
            dgvCart.AutoGenerateColumns = true;
            dgvCart.DataSource = dttb;
        }
        private void MoneyNeedToBuy()
        {
            string result = "Tổng tiền: ";
            int money = 0;
            for (int i = 0; i < dgvCart.RowCount; i++)
                money += Int32.Parse(dgvCart.Rows[i].Cells["ThanhTien"].Value.ToString());
            int numDigit = money.ToString().Count();
            for (int i = numDigit - 1; i >= 0; i--)
            {
                result += money.ToString()[numDigit - 1 - i];
                if (i % 3 == 0 && i > 0) 
                    result += ".";
            }
            result += " VND";
            lbMoney.Text = result;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataProvider dp = new DataProvider();
            dp.DeleteGameInCart(MSDH, dgvCart.CurrentRow.Cells["MSHH"].Value.ToString());
            ShowDataGridView(MSDH);
            MoneyNeedToBuy();
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("No Game No Life", "Logan", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete cart?", "Warning", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
                return;
            DataProvider dp = new DataProvider();
            dp.DeleteCart(MSDH);
            DataTable dttb = new DataTable();
            dgvCart.DataSource = dttb;
            lbMoney.Text = "Tổng tiền:";
        }
    }
}
