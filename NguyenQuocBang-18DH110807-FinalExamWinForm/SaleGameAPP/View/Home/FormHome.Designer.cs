namespace SaleGameAPP.View.Home
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.panelShadow = new System.Windows.Forms.Panel();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lbTitleChildForm = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconBtnMin = new FontAwesome.Sharp.IconPictureBox();
            this.iconBtnExit = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelHome = new System.Windows.Forms.Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelLogo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnGame = new FontAwesome.Sharp.IconButton();
            this.btnManageWorker = new FontAwesome.Sharp.IconButton();
            this.btnManageBill = new FontAwesome.Sharp.IconButton();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnExit)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.panelHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Black;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(327, 128);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1597, 10);
            this.panelShadow.TabIndex = 6;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.GhostWhite;
            this.iconCurrentChildForm.IconSize = 56;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(0, 23);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(56, 56);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // lbTitleChildForm
            // 
            this.lbTitleChildForm.AutoSize = true;
            this.lbTitleChildForm.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbTitleChildForm.Location = new System.Drawing.Point(62, 23);
            this.lbTitleChildForm.Name = "lbTitleChildForm";
            this.lbTitleChildForm.Size = new System.Drawing.Size(94, 35);
            this.lbTitleChildForm.TabIndex = 1;
            this.lbTitleChildForm.Text = "Home";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.Black;
            this.panelTitleBar.Controls.Add(this.iconBtnMin);
            this.panelTitleBar.Controls.Add(this.iconBtnExit);
            this.panelTitleBar.Controls.Add(this.lbTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(327, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1597, 128);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconBtnMin
            // 
            this.iconBtnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnMin.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.iconBtnMin.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnMin.IconSize = 64;
            this.iconBtnMin.Location = new System.Drawing.Point(1469, 0);
            this.iconBtnMin.Name = "iconBtnMin";
            this.iconBtnMin.Size = new System.Drawing.Size(64, 128);
            this.iconBtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBtnMin.TabIndex = 4;
            this.iconBtnMin.TabStop = false;
            this.iconBtnMin.Click += new System.EventHandler(this.iconBtnMin_Click);
            // 
            // iconBtnExit
            // 
            this.iconBtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExit.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.iconBtnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.iconBtnExit.IconSize = 64;
            this.iconBtnExit.Location = new System.Drawing.Point(1533, 0);
            this.iconBtnExit.Name = "iconBtnExit";
            this.iconBtnExit.Size = new System.Drawing.Size(64, 128);
            this.iconBtnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.iconBtnExit.TabIndex = 2;
            this.iconBtnExit.TabStop = false;
            this.iconBtnExit.Click += new System.EventHandler(this.iconBtnExit_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(17)))), ((int)(((byte)(18)))));
            this.panelDesktop.Controls.Add(this.panelHome);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(327, 138);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1597, 917);
            this.panelDesktop.TabIndex = 7;
            // 
            // panelHome
            // 
            this.panelHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHome.Controls.Add(this.lbTime);
            this.panelHome.Controls.Add(this.pictureBox1);
            this.panelHome.Location = new System.Drawing.Point(315, 134);
            this.panelHome.Name = "panelHome";
            this.panelHome.Size = new System.Drawing.Size(946, 614);
            this.panelHome.TabIndex = 15;
            // 
            // lbTime
            // 
            this.lbTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(172)))), ((int)(((byte)(220)))));
            this.lbTime.Location = new System.Drawing.Point(272, 408);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(32, 35);
            this.lbTime.TabIndex = 20;
            this.lbTime.Text = "1";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(298, 147);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(97, 10, 97, 10);
            this.pictureBox1.Size = new System.Drawing.Size(369, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Black;
            this.panelLogo.Controls.Add(this.picLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(10, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(297, 220);
            this.panelLogo.TabIndex = 5;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Black;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(84, 17);
            this.picLogo.Margin = new System.Windows.Forms.Padding(10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Padding = new System.Windows.Forms.Padding(97, 10, 97, 10);
            this.picLogo.Size = new System.Drawing.Size(120, 110);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 12;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnOrder.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconSize = 48;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(10, 330);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrder.Rotation = 0D;
            this.btnOrder.Size = new System.Drawing.Size(297, 110);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Orders";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGame
            // 
            this.btnGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGame.FlatAppearance.BorderSize = 0;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnGame.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGame.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGame.IconChar = FontAwesome.Sharp.IconChar.Gamepad;
            this.btnGame.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGame.IconSize = 48;
            this.btnGame.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.Location = new System.Drawing.Point(10, 220);
            this.btnGame.Name = "btnGame";
            this.btnGame.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGame.Rotation = 0D;
            this.btnGame.Size = new System.Drawing.Size(297, 110);
            this.btnGame.TabIndex = 7;
            this.btnGame.Text = "Game";
            this.btnGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGame.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGame.UseVisualStyleBackColor = true;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnManageWorker
            // 
            this.btnManageWorker.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageWorker.FlatAppearance.BorderSize = 0;
            this.btnManageWorker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageWorker.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManageWorker.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageWorker.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageWorker.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnManageWorker.IconColor = System.Drawing.Color.Gainsboro;
            this.btnManageWorker.IconSize = 48;
            this.btnManageWorker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageWorker.Location = new System.Drawing.Point(10, 550);
            this.btnManageWorker.Name = "btnManageWorker";
            this.btnManageWorker.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManageWorker.Rotation = 0D;
            this.btnManageWorker.Size = new System.Drawing.Size(297, 110);
            this.btnManageWorker.TabIndex = 8;
            this.btnManageWorker.Text = "Manage Worker";
            this.btnManageWorker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageWorker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageWorker.UseVisualStyleBackColor = true;
            this.btnManageWorker.Click += new System.EventHandler(this.btnManageWorker_Click);
            // 
            // btnManageBill
            // 
            this.btnManageBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageBill.FlatAppearance.BorderSize = 0;
            this.btnManageBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBill.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnManageBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBill.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnManageBill.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            this.btnManageBill.IconColor = System.Drawing.Color.Gainsboro;
            this.btnManageBill.IconSize = 48;
            this.btnManageBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBill.Location = new System.Drawing.Point(10, 440);
            this.btnManageBill.Name = "btnManageBill";
            this.btnManageBill.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnManageBill.Rotation = 0D;
            this.btnManageBill.Size = new System.Drawing.Size(297, 110);
            this.btnManageBill.TabIndex = 9;
            this.btnManageBill.Text = "Manage Bill";
            this.btnManageBill.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageBill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBill.UseVisualStyleBackColor = true;
            this.btnManageBill.Click += new System.EventHandler(this.btnManageBill_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnHelp.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.PhoneAlt;
            this.btnHelp.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHelp.IconSize = 48;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(10, 660);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHelp.Rotation = 0D;
            this.btnHelp.Size = new System.Drawing.Size(297, 110);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.btnHelp);
            this.panelMenu.Controls.Add(this.btnManageWorker);
            this.panelMenu.Controls.Add(this.btnManageBill);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.btnGame);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelMenu.Size = new System.Drawing.Size(327, 1055);
            this.panelMenu.TabIndex = 4;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconBtnExit)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelHome.ResumeLayout(false);
            this.panelHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelShadow;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lbTitleChildForm;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconBtnExit;
        private FontAwesome.Sharp.IconPictureBox iconBtnMin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Panel panelHome;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox picLogo;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnGame;
        private FontAwesome.Sharp.IconButton btnManageWorker;
        private FontAwesome.Sharp.IconButton btnManageBill;
        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.Panel panelMenu;
    }
}