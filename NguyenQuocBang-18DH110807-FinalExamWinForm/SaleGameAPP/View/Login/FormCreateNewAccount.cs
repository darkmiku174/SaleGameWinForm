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
        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            if (tbID.Text == "")
                MessageBox.Show("Please type your ID!");
            else if (dp.CheckIDUsed(tbID.Text) == tbID.Text)
                MessageBox.Show("ID is used ");
            else if (dp.CheckIDExist(tbID.Text) == "")
                MessageBox.Show("ID is not exits");
        }

        private void tbPass_Click(object sender, EventArgs e)
        {
            if (tbUser.Text=="")
                MessageBox.Show("Please type your username!");
            else if (dp.CheckUserNameExist(tbUser.Text) != "")
                MessageBox.Show("Username is exist");
            else
                tbCofirm.Enabled = true;
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
            string patdi = @"\d+"; //match digits
            string patupp = @"[A-Z]+"; //match upper cases
            string patlow = @"[a-z]+"; //match lower cases
            string patsym = @"[`~!@$%^&\\-\\+*/_=,;.':|\\(\\)\\[\\]\\{\\}]+"; //match symbols
            Match id = Regex.Match(tbPass.Text, patdi);
            Match upp = Regex.Match(tbPass.Text, patupp);
            Match low = Regex.Match(tbPass.Text, patlow);
            Match sym = Regex.Match(tbPass.Text, patsym);
            if (id.Success && upp.Success && low.Success && sym.Success)
                tbCofirm.Enabled = true;              
        }

        private void tbCofirm_TextChanged(object sender, EventArgs e)
        {
            btnCreate.Enabled = false;
            if (tbCofirm.Text == tbPass.Text)
                btnCreate.Enabled = true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (dp.CheckUserNameAndIDUsed(tbID.Text, tbUser.Text) > 0 || dp.CheckIDUsed(tbID.Text) == tbID.Text || dp.CheckIDExist(tbID.Text) == "" || dp.CheckUserNameExist(tbUser.Text) != "" || tbID.Text == "" || tbUser.Text == "") 
                MessageBox.Show("Can't create new account");
            else
            {
                MessageBox.Show("Successful");
                dp.InsertAccount(tbID.Text, tbUser.Text, tbPass.Text);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
