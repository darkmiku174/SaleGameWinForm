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

namespace SaleGameAPP.View.Login
{
    public partial class FormLogin : Form
    {
        DataProvider dp = new DataProvider();
        public FormLogin()
        {
            InitializeComponent();
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Save();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string pass = tbPass.Text;
            DataProvider dp = new DataProvider();
            bool confirmPass = dp.HashPass(tbUser.Text, tbPass.Text);
            if (confirmPass)
            {
                MessageBox.Show("Successful login");
                int id = dp.AutoIdLogin();
                dp.HistoryLogIn(id, tbUser.Text, "Login", DateTime.Now);
                this.Enabled = false;
                this.Visible = false;
                Properties.Settings.Default.Username = tbUser.Text;
                Properties.Settings.Default.Save();
                SaleGameAPP.View.Home.FormHome formHome = new SaleGameAPP.View.Home.FormHome();
                formHome.Show();
                formHome.FormClosed += new FormClosedEventHandler(OnCloseForm);
            }
            else
                MessageBox.Show("Fail login");
        }
        private void OnCloseForm(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            this.Visible = true;
            Properties.Settings.Default.Username = "";
            Properties.Settings.Default.Save();
            tbUser.Text = "Username";
            tbPass.Text = "Password";
            tbPass.PasswordChar = '\0';
        }
        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Enabled = false;
            this.Visible = false;
            FormCreateNewAccount formCreateAcc = new FormCreateNewAccount();
            formCreateAcc.Show();
            formCreateAcc.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void iconBtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbUser_Click(object sender, EventArgs e)
        {
            tbUser.Text = "";
        }

        private void tbPass_Click(object sender, EventArgs e)
        {
            tbPass.Text = "";
            tbPass.PasswordChar = '*';
        }
        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            tbPass.PasswordChar = '*';
        }
    }
}
