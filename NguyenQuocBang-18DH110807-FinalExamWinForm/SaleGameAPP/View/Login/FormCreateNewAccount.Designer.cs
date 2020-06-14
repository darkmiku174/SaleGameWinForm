namespace SaleGameAPP.View.Login
{
    partial class FormCreateNewAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateNewAccount));
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.picPass = new System.Windows.Forms.PictureBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.lbUser = new System.Windows.Forms.Label();
            this.lbPass = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCofirm = new System.Windows.Forms.Label();
            this.tbCofirm = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(183, 19);
            this.picLogo.Margin = new System.Windows.Forms.Padding(10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(128, 128);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.BackColor = System.Drawing.Color.White;
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(27, 311);
            this.picUser.Margin = new System.Windows.Forms.Padding(10);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(64, 64);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picUser.TabIndex = 2;
            this.picUser.TabStop = false;
            // 
            // picPass
            // 
            this.picPass.BackColor = System.Drawing.Color.White;
            this.picPass.Image = ((System.Drawing.Image)(resources.GetObject("picPass.Image")));
            this.picPass.Location = new System.Drawing.Point(27, 411);
            this.picPass.Margin = new System.Windows.Forms.Padding(10);
            this.picPass.Name = "picPass";
            this.picPass.Size = new System.Drawing.Size(64, 64);
            this.picPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picPass.TabIndex = 3;
            this.picPass.TabStop = false;
            // 
            // tbUser
            // 
            this.tbUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(142, 345);
            this.tbUser.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(254, 30);
            this.tbUser.TabIndex = 4;
            this.tbUser.Click += new System.EventHandler(this.tbUser_Click);
            // 
            // tbPass
            // 
            this.tbPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPass.Location = new System.Drawing.Point(142, 445);
            this.tbPass.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbPass.Multiline = true;
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(254, 30);
            this.tbPass.TabIndex = 5;
            this.tbPass.Click += new System.EventHandler(this.tbPass_Click);
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // lbUser
            // 
            this.lbUser.AutoSize = true;
            this.lbUser.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(137, 300);
            this.lbUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(129, 27);
            this.lbUser.TabIndex = 6;
            this.lbUser.Text = "Username:";
            // 
            // lbPass
            // 
            this.lbPass.AutoSize = true;
            this.lbPass.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPass.Location = new System.Drawing.Point(137, 401);
            this.lbPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPass.Name = "lbPass";
            this.lbPass.Size = new System.Drawing.Size(124, 27);
            this.lbPass.TabIndex = 7;
            this.lbPass.Text = "Password:";
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.Black;
            this.btnCreate.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(69, 627);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(119, 47);
            this.btnCreate.TabIndex = 8;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 521);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lbCofirm
            // 
            this.lbCofirm.AutoSize = true;
            this.lbCofirm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCofirm.Location = new System.Drawing.Point(137, 507);
            this.lbCofirm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCofirm.Name = "lbCofirm";
            this.lbCofirm.Size = new System.Drawing.Size(215, 27);
            this.lbCofirm.TabIndex = 11;
            this.lbCofirm.Text = "Confirm Password:";
            // 
            // tbCofirm
            // 
            this.tbCofirm.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCofirm.Location = new System.Drawing.Point(142, 555);
            this.tbCofirm.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbCofirm.Multiline = true;
            this.tbCofirm.Name = "tbCofirm";
            this.tbCofirm.PasswordChar = '*';
            this.tbCofirm.Size = new System.Drawing.Size(254, 30);
            this.tbCofirm.TabIndex = 10;
            this.tbCofirm.Click += new System.EventHandler(this.tbCofirm_Click);
            this.tbCofirm.TextChanged += new System.EventHandler(this.tbCofirm_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Black;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(309, 627);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 47);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbID.Location = new System.Drawing.Point(137, 195);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(132, 27);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "ID (MSNV):";
            // 
            // tbID
            // 
            this.tbID.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbID.Location = new System.Drawing.Point(142, 240);
            this.tbID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbID.Multiline = true;
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(254, 30);
            this.tbID.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(27, 206);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // FormCreateNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 739);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbCofirm);
            this.Controls.Add(this.tbCofirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lbPass);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.picPass);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.picLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormCreateNewAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Account";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.PictureBox picPass;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Label lbPass;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCofirm;
        private System.Windows.Forms.TextBox tbCofirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}