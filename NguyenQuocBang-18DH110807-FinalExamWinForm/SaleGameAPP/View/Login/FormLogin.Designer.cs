namespace SaleGameAPP.View.Login
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.cbRePass = new System.Windows.Forms.CheckBox();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.linkForgetPass = new System.Windows.Forms.LinkLabel();
            this.iconBtnExit = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(221, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(128, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.Lime;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(101, 191);
            this.picUser.Margin = new System.Windows.Forms.Padding(10);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(64, 64);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 1;
            this.picUser.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.BackColor = System.Drawing.Color.Lime;
            this.picPass.Image = ((System.Drawing.Image)(resources.GetObject("picPass.Image")));
            this.picPass.Location = new System.Drawing.Point(101, 292);
            this.picPass.Margin = new System.Windows.Forms.Padding(10);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(64, 64);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPass.TabIndex = 2;
            this.picPass.TabStop = false;
            // 
            // tbUser
            // 
            this.tbUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.ForeColor = System.Drawing.SystemColors.Window;
            this.tbUser.Location = new System.Drawing.Point(205, 225);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(255, 30);
            this.tbUser.TabIndex = 3;
            this.tbUser.Text = "Username";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.Color.Lime;
            this.tbPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(205, 322);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(255, 30);
            this.tbPass.TabIndex = 4;
            this.tbPass.Text = "Password";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Lime;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(166, 453);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 47);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cbRePass
            // 
            this.cbRePass.AutoSize = true;
            this.cbRePass.BackColor = System.Drawing.Color.Maroon;
            this.cbRePass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRePass.Location = new System.Drawing.Point(123, 399);
            this.cbRePass.Name = "cbRePass";
            this.cbRePass.Size = new System.Drawing.Size(217, 26);
            this.cbRePass.TabIndex = 8;
            this.cbRePass.Text = "Remember Password";
            this.cbRePass.UseVisualStyleBackColor = false;
            this.cbRePass.CheckedChanged += new System.EventHandler(this.cbRePass_CheckedChanged);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.BackColor = System.Drawing.Color.Maroon;
            this.linkCreateAccount.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCreateAccount.LinkColor = System.Drawing.Color.Black;
            this.linkCreateAccount.Location = new System.Drawing.Point(162, 599);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(155, 19);
            this.linkCreateAccount.TabIndex = 9;
            this.linkCreateAccount.TabStop = true;
            this.linkCreateAccount.Text = "Create new account";
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
            // 
            // linkForgetPass
            // 
            this.linkForgetPass.AutoSize = true;
            this.linkForgetPass.BackColor = System.Drawing.Color.Maroon;
            this.linkForgetPass.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkForgetPass.LinkColor = System.Drawing.Color.Black;
            this.linkForgetPass.Location = new System.Drawing.Point(176, 559);
            this.linkForgetPass.Name = "linkForgetPass";
            this.linkForgetPass.Size = new System.Drawing.Size(141, 19);
            this.linkForgetPass.TabIndex = 10;
            this.linkForgetPass.TabStop = true;
            this.linkForgetPass.Text = "Forget Password?";
            this.linkForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkForgetPass_LinkClicked);
            // 
            // iconBtnExit
            // 
            this.iconBtnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.iconBtnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.iconBtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnExit.IconColor = System.Drawing.Color.DarkRed;
            this.iconBtnExit.IconSize = 49;
            this.iconBtnExit.Location = new System.Drawing.Point(514, 12);
            this.iconBtnExit.Name = "iconBtnExit";
            this.iconBtnExit.Size = new System.Drawing.Size(56, 49);
            this.iconBtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBtnExit.TabIndex = 26;
            this.iconBtnExit.TabStop = false;
            this.iconBtnExit.Click += new System.EventHandler(this.iconBtnExit_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.ClientSize = new System.Drawing.Size(582, 653);
            this.Controls.Add(this.iconBtnExit);
            this.Controls.Add(this.linkForgetPass);
            this.Controls.Add(this.linkCreateAccount);
            this.Controls.Add(this.cbRePass);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picLogo);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.Opacity = 0.85D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox cbRePass;
        private System.Windows.Forms.LinkLabel linkCreateAccount;
        private System.Windows.Forms.LinkLabel linkForgetPass;
        private FontAwesome.Sharp.IconPictureBox iconBtnExit;
    }
}

