﻿using System;
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
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            if(Properties.Settings.Default.Username !="")
                tbUser.Text = Properties.Settings.Default.Username;
            if (tbUser.Text != "Username")
            {
                cbRePass.Checked = true;
                //tbPass.Text = dp.DeHashPass(tbUser.Text);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string pass = tbPass.Text;
            /*if(cbRePass.Checked)
            {
                if (dp.DeHashPass(username) == pass)
                    MessageBox.Show("Login Successful");
                else
                    MessageBox.Show("Login Failed");
            }
            else
            {
                PasswordHash hash = new PasswordHash(pass,salt);
                byte[] hashBytes = hash.ToArray();
                //string hashPass = PasswordHash.OutputHash(hashBytes);
                //if (dp.DeHashPass(username) == hashPass)
                    //MessageBox.Show("Login Successful");
                //else
                    //MessageBox.Show("Login Failed");
            }*/
            this.Enabled = false;
            this.Visible = false;
            SaleGameAPP.View.Home.FormHome formHome = new SaleGameAPP.View.Home.FormHome();
            formHome.Show();
            formHome.FormClosed += new FormClosedEventHandler(OnCloseForm);
        }

        private void cbRePass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRePass.Checked)
            {
                Properties.Settings.Default.Username = tbUser.Text;
                Properties.Settings.Default.Save();
            }

            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Save();
            }
        }

        private void OnCloseForm(object sender, FormClosedEventArgs e)
        {
            this.Enabled = true;
            this.Visible = true;
        }

        private void linkForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Enabled = false;
            this.Visible = false;
            FormForgetPassword formForget = new FormForgetPassword();
            formForget.Show();
            formForget.FormClosed += new FormClosedEventHandler(OnCloseForm);
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
