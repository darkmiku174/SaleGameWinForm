using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace SaleGameAPP.View.Login
{
    public partial class FormCreateNewAccount : Form
    {
        private DataProvider dp = new DataProvider();
        public FormCreateNewAccount()
        {
            InitializeComponent();
            tbCofirm.Enabled = false;
        }
        private void tbPass_Click(object sender, EventArgs e)
        {
            tbPass.Text = "";
            tbPass.PasswordChar = '*';
        }

        private void tbCofirm_Click(object sender, EventArgs e)
        {
            if (tbPass.Text == "")
                MessageBox.Show("Please type your password!");
        }

        private enum PasswordScore
        {
            Blank = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }
        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
            string patdi = @"\d+"; //match digits
            string patupp = @"[A-Z]+"; //match upper cases
            string patlow = @"[a-z]+"; //match lower cases
            string patsym = @"[!@#$%^&*()_+=\[{\]};:<>|./?,-]"; //match symbols
            Match id = Regex.Match(tbPass.Text, patdi);
            Match upp = Regex.Match(tbPass.Text, patupp);
            Match low = Regex.Match(tbPass.Text, patlow);
            Match sym = Regex.Match(tbPass.Text, patsym);
            if (id.Success && upp.Success && low.Success && sym.Success && tbPass.Text.Length >= 8)
                tbCofirm.Enabled = true;              
        }

        private void tbCofirm_TextChanged(object sender, EventArgs e)
        {
            tbCofirm.PasswordChar = '*';
            btnCreate.Enabled = false;
            if (tbCofirm.Text == tbPass.Text)
                btnCreate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dp.CheckIDUsed(tbID.Text) == tbID.Text || dp.CheckIDExist(tbID.Text) == "" || tbID.Text == "" || tbPass.Text == "" || tbPass.Text != tbCofirm.Text)
            {
                MessageBox.Show("Can't create new account");
                tbPass.Text = "";
                tbCofirm.Text = "";
            }
            else
            {
                MessageBox.Show("Successful");
                dp.InsertAccount(tbID.Text, tbPass.Text);
                tbID.Text = "";
                tbPass.Text = "";
                tbCofirm.Text = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbID_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
        }
    }
}
