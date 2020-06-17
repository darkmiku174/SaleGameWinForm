using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SaleGameAPP.View.Service
{
    public partial class FormCreateBill : Form
    {
        private string MSHH = "";
        public FormCreateBill(string MSHH)
        {
            InitializeComponent();
            this.MSHH = MSHH;
        }
        private bool CheckInput()
        {
            if (tbSoLuong.Text == "" || tbTiLeGiam.Text == "")
            {
                MessageBox.Show("Please type full information!!!");
                return false;
            }
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            if (!regex.IsMatch(tbSoLuong.Text) || !regex.IsMatch(tbTiLeGiam.Text))
            {
                MessageBox.Show("Please type number!!!");
                return false;
            }
            if(Int32.Parse(tbSoLuong.Text)<=0)
            {
                MessageBox.Show("Please type number bigger than 0 at SoLuong");
                return false;
            }
            if (Int32.Parse(tbTiLeGiam.Text) < 0 || Int32.Parse(tbTiLeGiam.Text)>100)
            {
                MessageBox.Show("Please type number bigger than -1 and less than 101 at TiLeGiam");
                return false;
            }
            return true;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
                return;
            DataProvider dp = new DataProvider();
            string MSDH = dp.CurrentMSDH();
            int soLuong = Int32.Parse(tbSoLuong.Text);
            int tiLeGiam = Int32.Parse(tbTiLeGiam.Text);
            dp.AddCart(MSDH, MSHH, soLuong, tiLeGiam);
            DialogResult result= MessageBox.Show("Successful", "Notification", MessageBoxButtons.OK);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
